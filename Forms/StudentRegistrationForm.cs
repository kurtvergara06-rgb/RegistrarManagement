using RegistrarManagement.Helpers;
using RegistrarManagement.Models;
using RegistrarManagement.Services;
using System.Drawing.Drawing2D;

namespace RegistrarManagement.Forms;

public partial class StudentRegistrationForm : Form
{
    private readonly RegistrationService _service = new();
    private readonly StudentService _students = new();
    private readonly SharedDataService _shared = new();

    private List<AcademicOffering> _academicOfferings = [];

    private string? _selectedRegistrationId;
    private bool _isLoadingRecord;
    private bool _sortAscending = false;

    public StudentRegistrationForm()
    {
        InitializeComponent();

        Color maroon =
            Color.FromArgb(128, 0, 24);

        Color red =
            Color.FromArgb(220, 53, 69);

        Color gray =
            Color.FromArgb(180, 180, 180);

        SetRoundedButton(
            btnAdd,
            10,
            maroon
        );

        SetRoundedButton(
            btnUpdate,
            10,
            gray
        );

        SetRoundedButton(
            btnDelete,
            10,
            red
        );

        SetRoundedButton(
            btnClear,
            10,
            maroon
        );

        SetRoundedButton(
            btnRefresh,
            10,
            maroon
        );

        SetRoundedButton(
            btnSearch,
            8,
            maroon
        );

        if (btnsort != null)
        {
            SetRoundedButton(
                btnsort,
                8,
                maroon
            );

            btnsort.Enabled = true;
            btnsort.Text = "Sort: Z-A";
        }

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

        cmbRegistrationStatus.Items.AddRange(
        [
            "Registered",
            "Pending",
            "On Hold",
            "Cancelled"
        ]);

        if (cmbfilter != null)
        {
            cmbfilter.Items.Clear();
            cmbfilter.Items.AddRange(
            [
                "All Statuses",
                "Registered",
                "Pending",
                "On Hold",
                "Cancelled"
            ]);

            cmbfilter.SelectedIndex = 0;
        }
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

        cmbStudent.DataSource = students
            .OrderBy(x => x.FullName)
            .ToList();

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

    private GraphicsPath GetRoundedPath(
        Rectangle rectangle,
        int radius)
    {
        GraphicsPath path = new GraphicsPath();

        int diameter = radius * 2;

        path.AddArc(
            rectangle.X,
            rectangle.Y,
            diameter,
            diameter,
            180,
            90
        );

        path.AddArc(
            rectangle.Right - diameter,
            rectangle.Y,
            diameter,
            diameter,
            270,
            90
        );

        path.AddArc(
            rectangle.Right - diameter,
            rectangle.Bottom - diameter,
            diameter,
            diameter,
            0,
            90
        );

        path.AddArc(
            rectangle.X,
            rectangle.Bottom - diameter,
            diameter,
            diameter,
            90,
            90
        );

        path.CloseFigure();

        return path;
    }

    private void SetRoundedButton(
        Button button,
        int radius,
        Color borderColor)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;

        void ApplyRegion()
        {
            Rectangle rectangle =
                new Rectangle(
                    0,
                    0,
                    button.Width,
                    button.Height
                );

            using GraphicsPath path =
                GetRoundedPath(
                    rectangle,
                    radius
                );

            button.Region?.Dispose();
            button.Region =
                new Region(path);
        }

        button.Paint += (sender, e) =>
        {
            e.Graphics.SmoothingMode =
                SmoothingMode.AntiAlias;

            Rectangle rectangle =
                new Rectangle(
                    1,
                    1,
                    button.Width - 3,
                    button.Height - 3
                );

            using GraphicsPath path =
                GetRoundedPath(
                    rectangle,
                    radius
                );

            using Pen pen =
                new Pen(
                    borderColor,
                    1.5F
                );

            e.Graphics.DrawPath(
                pen,
                path
            );
        };

        button.Resize +=
            (sender, e) => ApplyRegion();

        ApplyRegion();
    }

    private StudentRegistration BuildRegistration(
        string registrationId)
    {
        return new StudentRegistration
        {
            RegistrationId = registrationId,

            StudentId =
                (cmbStudent.SelectedItem as Student)
                    ?.StudentId
                ?? string.Empty,

            ProgramId =
                (cmbProgram.SelectedItem as ProgramModel)
                    ?.ProgramId
                ?? string.Empty,

            SchoolYear =
                cmbSchoolYear.Text,

            Semester =
                cmbSemester.Text,

            YearLevel =
                cmbYearLevel.Text,

            RegistrationDate =
                dtpRegistrationDate.Value
                    .ToString("yyyy-MM-dd"),

            RegistrationStatus =
                cmbRegistrationStatus.Text,

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
                cmbRegistrationStatus.Text
            );
    }

    private async Task ApplySearchSortAndFilterAsync()
    {
        List<StudentRegistration> records =
            await _service.GetAllAsync();

        List<Student> students =
            await _students.GetAllAsync();

        string searchText =
            txtSearch.Text
                .Trim()
                .ToLowerInvariant();

        string selectedStatus =
            cmbfilter?.SelectedItem?.ToString()
            ?? "All Statuses";

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            records = records
                .Where(record =>
                {
                    Student? matchedStudent =
                        students.FirstOrDefault(student =>
                            student.StudentId.Equals(
                                record.StudentId,
                                StringComparison.OrdinalIgnoreCase));

                    string studentName =
                        matchedStudent?.FullName
                            ?.ToLowerInvariant()
                        ?? string.Empty;

                    return
                        record.RegistrationId
                            .ToLowerInvariant()
                            .Contains(searchText)
                        || record.StudentId
                            .ToLowerInvariant()
                            .Contains(searchText)
                        || record.SchoolYear
                            .ToLowerInvariant()
                            .Contains(searchText)
                        || record.RegistrationStatus
                            .ToLowerInvariant()
                            .Contains(searchText)
                        || studentName.Contains(searchText);
                })
                .ToList();
        }

        if (!selectedStatus.Equals(
                "All Statuses",
                StringComparison.OrdinalIgnoreCase))
        {
            records = records
                .Where(record =>
                    record.RegistrationStatus.Equals(
                        selectedStatus,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        records = _sortAscending
            ? records
                .OrderBy(record =>
                {
                    Student? matchedStudent =
                        students.FirstOrDefault(student =>
                            student.StudentId.Equals(
                                record.StudentId,
                                StringComparison.OrdinalIgnoreCase));

                    return matchedStudent?.FullName
                        ?? string.Empty;
                })
                .ToList()
            : records
                .OrderByDescending(record =>
                {
                    Student? matchedStudent =
                        students.FirstOrDefault(student =>
                            student.StudentId.Equals(
                                record.StudentId,
                                StringComparison.OrdinalIgnoreCase));

                    return matchedStudent?.FullName
                        ?? string.Empty;
                })
                .ToList();

        dgvRegistrations.DataSource = records;
        dgvRegistrations.ClearSelection();
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

            List<StudentRegistration> existingRecords =
                await _service.GetAllAsync();

            StudentRegistration registration =
                BuildRegistration(
                    IdGenerator.CreateNext(
                        "REG",
                        existingRecords.Select(x => x.RegistrationId)
                    )
                );

            bool duplicate = existingRecords.Any(record =>
                record.StudentId ==
                    registration.StudentId
                && record.SchoolYear ==
                    registration.SchoolYear
                && record.Semester ==
                    registration.Semester
            );

            if (duplicate)
            {
                MessageBox.Show(
                    "This student is already registered " +
                    "for this school year and semester.",
                    "Duplicate Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult addConfirm =
                MessageBox.Show(
                    "Save this registration record?",
                    "Confirm Add",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (addConfirm != DialogResult.Yes)
            {
                return;
            }

            await _service.SaveAsync(registration);
            await LoadGridAsync();
            ClearFields();

            MessageBox.Show(
                "Registration saved to Firebase.",
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
        if (_selectedRegistrationId == null)
        {
            MessageBox.Show(
                "Select a registration first.",
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
            StudentRegistration registration =
                BuildRegistration(
                    _selectedRegistrationId
                );

            DialogResult updateConfirm =
                MessageBox.Show(
                    "Update this registration record?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (updateConfirm != DialogResult.Yes)
            {
                return;
            }

            await _service.SaveAsync(registration);
            await LoadGridAsync();
            ClearFields();

            MessageBox.Show(
                "Registration updated.",
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
        if (_selectedRegistrationId == null)
        {
            MessageBox.Show(
                "Select a registration first.",
                "Delete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        DialogResult result = MessageBox.Show(
            "Delete the selected registration?",
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
                _selectedRegistrationId
            );

            await LoadGridAsync();
            ClearFields();

            MessageBox.Show(
                "Registration deleted.",
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

            if (cmbfilter != null)
            {
                cmbfilter.SelectedIndex = 0;
            }

            _sortAscending = false;

            if (btnsort != null)
            {
                btnsort.Text = "Sort: Z-A";
            }
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
            await ApplySearchSortAndFilterAsync();
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
        dgvRegistrations.DataSource =
            await _service.GetAllAsync();

        dgvRegistrations.ClearSelection();
    }

    private void dgvRegistrations_CellClick(
        object? sender,
        DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        object? selectedItem =
            dgvRegistrations.Rows[e.RowIndex]
                .DataBoundItem;

        if (selectedItem
            is not StudentRegistration registration)
        {
            return;
        }

        _isLoadingRecord = true;

        try
        {
            _selectedRegistrationId =
                registration.RegistrationId;

            SelectStudent(registration.StudentId);
            SelectProgram(registration.ProgramId);
            SelectSchoolYear(registration.SchoolYear);

            LoadSemestersForSchoolYear(
                registration.SchoolYear
            );

            cmbSemester.Text =
                registration.Semester;

            cmbYearLevel.Text =
                registration.YearLevel;

            cmbRegistrationStatus.Text =
                registration.RegistrationStatus;

            txtRemarks.Text =
                registration.Remarks;

            if (DateTime.TryParse(
                registration.RegistrationDate,
                out DateTime registrationDate
            ))
            {
                dtpRegistrationDate.Value =
                    registrationDate;
            }

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

    private void SelectSchoolYear(
        string schoolYear)
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
        _selectedRegistrationId = null;

        cmbStudent.Enabled = true;

        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;

        dgvRegistrations.ClearSelection();
    }

    private void ClearFields()
    {
        _isLoadingRecord = true;

        try
        {
            _selectedRegistrationId = null;

            cmbStudent.Enabled = true;

            cmbStudent.SelectedIndex = -1;
            cmbProgram.SelectedIndex = -1;
            cmbYearLevel.SelectedIndex = -1;
            cmbRegistrationStatus.SelectedIndex = -1;

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

            dtpRegistrationDate.Value =
                DateTime.Now;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            dgvRegistrations.ClearSelection();
        }
        finally
        {
            _isLoadingRecord = false;
        }
    }

    private void btnBack_Click(
        object? sender,
        EventArgs e)
    {
        Close();
    }

    private async void btnsort_Click(object sender, EventArgs e)
    {
        _sortAscending = !_sortAscending;

        btnsort.Text = _sortAscending
            ? "Sort: A-Z"
            : "Sort: Z-A";

        await ApplySearchSortAndFilterAsync();
    }

    private async void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_isLoadingRecord)
        {
            return;
        }

        await ApplySearchSortAndFilterAsync();
    }
}