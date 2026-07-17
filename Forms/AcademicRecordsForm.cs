using RegistrarManagement.Helpers;
using RegistrarManagement.Models;
using RegistrarManagement.Services;

namespace RegistrarManagement.Forms;

public partial class AcademicRecordsForm : Form
{
    private readonly AcademicRecordService _service = new();
    private readonly RegistrationService _registrations = new();
    private readonly StudentService _students = new();
    private readonly SharedDataService _shared = new();

    private List<AcademicOffering> _academicOfferings = [];

    private string? _selectedRecordId;
    private bool _isLoadingRecord;

    public AcademicRecordsForm()
    {
        InitializeComponent();

        // Program comes from the selected student's Firebase record.
        cmbProgram.Enabled = false;

        Load += Form_Load;

        cmbStudent.SelectedIndexChanged +=
            cmbStudent_SelectedIndexChanged;

        cmbSchoolYear.SelectedIndexChanged +=
            cmbSchoolYear_SelectedIndexChanged;

        cmbYearLevel.Items.AddRange(
        [
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"
        ]);

        cmbAcademicStatus.Items.AddRange(
        [
            "Regular",
            "Irregular",
            "Probation",
            "Graduating",
            "Graduated",
            "Inactive"
        ]);
    }

    private async void Form_Load(
        object? sender,
        EventArgs e)
    {
        try
        {
            await LoadProgramsAsync();
            await LoadStudentsAsync();
            await LoadAcademicOfferingsAsync();
            await LoadGridAsync();

            ClearRecordSelection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.ToString(),
                "Firebase Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private async Task LoadStudentsAsync()
    {
        List<Student> students =
            await _students.GetAllAsync();

        cmbStudent.DataSource = students;
        cmbStudent.DisplayMember =
            nameof(Student.FullName);

        cmbStudent.ValueMember =
            nameof(Student.StudentId);

        cmbStudent.SelectedIndex = -1;
    }

    private async Task LoadProgramsAsync()
    {
        List<ProgramModel> programs =
            await _shared.GetProgramsAsync();

        cmbProgram.DataSource = programs;
        cmbProgram.DisplayMember =
            nameof(ProgramModel.ProgramName);

        cmbProgram.ValueMember =
            nameof(ProgramModel.ProgramId);

        cmbProgram.SelectedIndex = -1;
    }

    private async Task LoadAcademicOfferingsAsync()
    {
        _academicOfferings =
            await _shared.GetAcademicOfferingsAsync();

        List<string> schoolYears = _academicOfferings
            .Select(offering => offering.SchoolYear)
            .Where(schoolYear =>
                !string.IsNullOrWhiteSpace(schoolYear))
            .Distinct()
            .OrderByDescending(schoolYear => schoolYear)
            .ToList();

        cmbSchoolYear.DataSource = schoolYears;

        if (schoolYears.Count > 0)
        {
            cmbSchoolYear.SelectedIndex = 0;

            LoadSemestersForSchoolYear(
                schoolYears[0]
            );
        }
        else
        {
            cmbSchoolYear.SelectedIndex = -1;
            cmbSemester.DataSource = null;
            cmbSemester.Items.Clear();
        }
    }

    private void cmbStudent_SelectedIndexChanged(
        object? sender,
        EventArgs e)
    {
        if (_isLoadingRecord)
        {
            return;
        }

        if (cmbStudent.SelectedItem is not Student student)
        {
            cmbProgram.SelectedIndex = -1;
            cmbYearLevel.SelectedIndex = -1;
            return;
        }

        SelectProgram(student.ProgramId);
        SelectYearLevel(student.YearLevel);
    }

    private void cmbSchoolYear_SelectedIndexChanged(
        object? sender,
        EventArgs e)
    {
        if (_isLoadingRecord)
        {
            return;
        }

        string schoolYear =
            cmbSchoolYear.SelectedItem?.ToString()
            ?? string.Empty;

        if (string.IsNullOrWhiteSpace(schoolYear))
        {
            cmbSemester.DataSource = null;
            cmbSemester.Items.Clear();
            return;
        }

        LoadSemestersForSchoolYear(schoolYear);
    }

    private void LoadSemestersForSchoolYear(
        string schoolYear)
    {
        List<string> semesters = _academicOfferings
            .Where(offering =>
                offering.SchoolYear.Equals(
                    schoolYear,
                    StringComparison.OrdinalIgnoreCase
                )
            )
            .Select(offering =>
                NormalizeSemester(offering.Semester)
            )
            .Where(semester =>
                !string.IsNullOrWhiteSpace(semester)
            )
            .Distinct()
            .OrderBy(semester => semester)
            .ToList();

        cmbSemester.DataSource = semesters;

        cmbSemester.SelectedIndex =
            semesters.Count > 0 ? 0 : -1;
    }

    private static string NormalizeSemester(
        string semester)
    {
        string value = semester.Trim();

        return value.ToLowerInvariant() switch
        {
            "1st" => "1st Semester",
            "first" => "1st Semester",
            "1st semester" => "1st Semester",

            "2nd" => "2nd Semester",
            "second" => "2nd Semester",
            "2nd semester" => "2nd Semester",

            "summer" => "Summer",

            _ => value
        };
    }

    private static string NormalizeYearLevel(
        string yearLevel)
    {
        string value = yearLevel.Trim();

        return value switch
        {
            "1" or "1.0" => "1st Year",
            "2" or "2.0" => "2nd Year",
            "3" or "3.0" => "3rd Year",
            "4" or "4.0" => "4th Year",
            _ => value
        };
    }

    private void SelectProgram(string programId)
    {
        cmbProgram.SelectedIndex = -1;

        for (int index = 0;
             index < cmbProgram.Items.Count;
             index++)
        {
            if (cmbProgram.Items[index] is ProgramModel program
                && program.ProgramId.Equals(
                    programId,
                    StringComparison.OrdinalIgnoreCase
                ))
            {
                cmbProgram.SelectedIndex = index;
                return;
            }
        }
    }

    private void SelectYearLevel(string yearLevel)
    {
        string normalizedYearLevel =
            NormalizeYearLevel(yearLevel);

        cmbYearLevel.SelectedIndex = -1;

        for (int index = 0;
             index < cmbYearLevel.Items.Count;
             index++)
        {
            string currentItem =
                cmbYearLevel.Items[index]?.ToString()
                ?? string.Empty;

            if (currentItem.Equals(
                normalizedYearLevel,
                StringComparison.OrdinalIgnoreCase
            ))
            {
                cmbYearLevel.SelectedIndex = index;
                return;
            }
        }
    }

    private AcademicRecord BuildRecord(string recordId)
    {
        return new AcademicRecord
        {
            RecordId = recordId,

            StudentId =
                (cmbStudent.SelectedItem as Student)
                    ?.StudentId
                ?? string.Empty,

            ProgramId =
                (cmbProgram.SelectedItem as ProgramModel)
                    ?.ProgramId
                ?? string.Empty,

            SchoolYear = cmbSchoolYear.Text,
            Semester = cmbSemester.Text,
            YearLevel = cmbYearLevel.Text,

            AcademicStatus =
                cmbAcademicStatus.Text,

            Remarks =
                txtRemarks.Text.Trim()
        };
    }

    private bool IsFormValid()
    {
        return cmbStudent.SelectedItem != null
            && cmbProgram.SelectedItem != null
            && ValidationHelper.Required(
                cmbSchoolYear.Text,
                cmbSemester.Text,
                cmbYearLevel.Text,
                cmbAcademicStatus.Text
            );
    }

    private async Task<bool> HasValidRegistrationAsync()
    {
        if (cmbStudent.SelectedItem is not Student student)
        {
            return false;
        }

        string selectedSchoolYear =
            cmbSchoolYear.Text.Trim();

        string selectedSemester =
            cmbSemester.Text.Trim();

        List<StudentRegistration> registrations =
            await _registrations.GetAllAsync();

        return registrations.Any(registration =>
            registration.StudentId.Equals(
                student.StudentId,
                StringComparison.OrdinalIgnoreCase
            )
            && registration.SchoolYear.Equals(
                selectedSchoolYear,
                StringComparison.OrdinalIgnoreCase
            )
            && registration.Semester.Equals(
                selectedSemester,
                StringComparison.OrdinalIgnoreCase
            )
            && registration.RegistrationStatus.Equals(
                "Registered",
                StringComparison.OrdinalIgnoreCase
            )
        );
    }

    private async void btnAdd_Click(
        object? sender,
        EventArgs e)
    {
        try
        {
            if (!IsFormValid())
            {
                MessageBox.Show(
                    "Complete all required fields.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            bool hasValidRegistration =
                await HasValidRegistrationAsync();

            if (!hasValidRegistration)
            {
                MessageBox.Show(
                    "This student is not officially registered " +
                    "for the selected school year and semester.",
                    "Registration Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            AcademicRecord record =
                BuildRecord(
                    IdGenerator.Create("AR")
                );

            List<AcademicRecord> existingRecords =
                await _service.GetAllAsync();

            bool duplicate = existingRecords.Any(existing =>
                existing.StudentId.Equals(
                    record.StudentId,
                    StringComparison.OrdinalIgnoreCase
                )
                && existing.SchoolYear.Equals(
                    record.SchoolYear,
                    StringComparison.OrdinalIgnoreCase
                )
                && existing.Semester.Equals(
                    record.Semester,
                    StringComparison.OrdinalIgnoreCase
                )
            );

            if (duplicate)
            {
                MessageBox.Show(
                    "This student already has an academic record " +
                    "for this school year and semester.",
                    "Duplicate Record",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            await _service.SaveAsync(record);
            await LoadGridAsync();

            ClearFields();

            MessageBox.Show(
                "Academic record saved to Firebase.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Save Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private async void btnUpdate_Click(
        object? sender,
        EventArgs e)
    {
        if (_selectedRecordId == null)
        {
            MessageBox.Show(
                "Select an academic record first.",
                "Update",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        if (!IsFormValid())
        {
            MessageBox.Show(
                "Complete all required fields.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        try
        {
            bool hasValidRegistration =
                await HasValidRegistrationAsync();

            if (!hasValidRegistration)
            {
                MessageBox.Show(
                    "This student is not officially registered " +
                    "for the selected school year and semester.",
                    "Registration Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            AcademicRecord record =
                BuildRecord(_selectedRecordId);

            await _service.SaveAsync(record);
            await LoadGridAsync();

            ClearFields();

            MessageBox.Show(
                "Academic record updated.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Update Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private async void btnDelete_Click(
        object? sender,
        EventArgs e)
    {
        if (_selectedRecordId == null)
        {
            MessageBox.Show(
                "Select an academic record first.",
                "Delete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        DialogResult result = MessageBox.Show(
            "Delete the selected academic record?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result != DialogResult.Yes)
        {
            return;
        }

        try
        {
            await _service.DeleteAsync(
                _selectedRecordId
            );

            await LoadGridAsync();
            ClearFields();

            MessageBox.Show(
                "Academic record deleted.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Delete Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void btnClear_Click(
        object? sender,
        EventArgs e)
    {
        ClearFields();
    }

    private async void btnRefresh_Click(
        object? sender,
        EventArgs e)
    {
        try
        {
            await LoadProgramsAsync();
            await LoadStudentsAsync();
            await LoadAcademicOfferingsAsync();
            await LoadGridAsync();

            ClearFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Refresh Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private async void btnSearch_Click(
        object? sender,
        EventArgs e)
    {
        try
        {
            string searchText =
                txtSearch.Text
                    .Trim()
                    .ToLowerInvariant();

            List<AcademicRecord> records =
                await _service.GetAllAsync();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvAcademicRecords.DataSource = records;
                dgvAcademicRecords.ClearSelection();
                return;
            }

            dgvAcademicRecords.DataSource = records
                .Where(record =>
                    record.RecordId
                        .ToLowerInvariant()
                        .Contains(searchText)
                    || record.StudentId
                        .ToLowerInvariant()
                        .Contains(searchText)
                    || record.SchoolYear
                        .ToLowerInvariant()
                        .Contains(searchText)
                    || record.AcademicStatus
                        .ToLowerInvariant()
                        .Contains(searchText)
                )
                .ToList();

            dgvAcademicRecords.ClearSelection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Search Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private async Task LoadGridAsync()
    {
        dgvAcademicRecords.DataSource =
            await _service.GetAllAsync();

        dgvAcademicRecords.ClearSelection();
    }

    private void dgvAcademicRecords_CellClick(
        object? sender,
        DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        object? selectedItem =
            dgvAcademicRecords.Rows[e.RowIndex]
                .DataBoundItem;

        if (selectedItem is not AcademicRecord record)
        {
            return;
        }

        _isLoadingRecord = true;

        try
        {
            _selectedRecordId = record.RecordId;

            SelectStudent(record.StudentId);
            SelectProgram(record.ProgramId);
            SelectSchoolYear(record.SchoolYear);

            LoadSemestersForSchoolYear(
                record.SchoolYear
            );

            cmbSemester.Text =
                record.Semester;

            cmbYearLevel.Text =
                record.YearLevel;

            cmbAcademicStatus.Text =
                record.AcademicStatus;

            txtRemarks.Text =
                record.Remarks;

            // Prevent changing the owner of an existing record.
            cmbStudent.Enabled = false;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        finally
        {
            _isLoadingRecord = false;
        }
    }

    private void SelectStudent(string studentId)
    {
        cmbStudent.SelectedIndex = -1;

        for (int index = 0;
             index < cmbStudent.Items.Count;
             index++)
        {
            if (cmbStudent.Items[index] is Student student
                && student.StudentId.Equals(
                    studentId,
                    StringComparison.OrdinalIgnoreCase
                ))
            {
                cmbStudent.SelectedIndex = index;
                return;
            }
        }
    }

    private void SelectSchoolYear(string schoolYear)
    {
        cmbSchoolYear.SelectedIndex = -1;

        for (int index = 0;
             index < cmbSchoolYear.Items.Count;
             index++)
        {
            string currentSchoolYear =
                cmbSchoolYear.Items[index]?.ToString()
                ?? string.Empty;

            if (currentSchoolYear.Equals(
                schoolYear,
                StringComparison.OrdinalIgnoreCase
            ))
            {
                cmbSchoolYear.SelectedIndex = index;
                return;
            }
        }
    }

    private void ClearRecordSelection()
    {
        _selectedRecordId = null;

        cmbStudent.Enabled = true;

        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;

        dgvAcademicRecords.ClearSelection();
    }

    private void ClearFields()
    {
        _isLoadingRecord = true;

        try
        {
            _selectedRecordId = null;

            cmbStudent.Enabled = true;

            cmbStudent.SelectedIndex = -1;
            cmbProgram.SelectedIndex = -1;
            cmbYearLevel.SelectedIndex = -1;
            cmbAcademicStatus.SelectedIndex = -1;

            if (cmbSchoolYear.Items.Count > 0)
            {
                cmbSchoolYear.SelectedIndex = 0;

                string schoolYear =
                    cmbSchoolYear.SelectedItem
                        ?.ToString()
                    ?? string.Empty;

                LoadSemestersForSchoolYear(
                    schoolYear
                );
            }
            else
            {
                cmbSchoolYear.SelectedIndex = -1;
                cmbSemester.DataSource = null;
                cmbSemester.Items.Clear();
            }

            txtRemarks.Clear();
            txtSearch.Clear();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            dgvAcademicRecords.ClearSelection();
        }
        finally
        {
            _isLoadingRecord = false;
        }
    }
}