using System.Drawing.Drawing2D;
using RegistrarManagement.Helpers;
using RegistrarManagement.Models;
using RegistrarManagement.Services;

namespace RegistrarManagement.Forms;

public partial class StudentClearancesForm : Form
{
    private readonly ClearanceService _service = new();
    private readonly StudentService _students = new();

    private string? _id;

    public StudentClearancesForm()
    {
        InitializeComponent();

        Load += Form_Load;

        // Registrar Status is automatic.
        cmbRegistrarStatus.Items.AddRange(new[]
        {
            "Cleared",
            "Pending",
            "Not Cleared",
            "No Record"
        });

        cmbRegistrarStatus.Enabled = false;

        // Accounting Status is automatic.
        cmbAccountingStatus.Items.AddRange(new[]
        {
            "Cleared",
            "Not Cleared",
            "No Record"
        });

        cmbAccountingStatus.Enabled = false;

        // UI design
        Color maroon = Color.FromArgb(128, 0, 24);
        Color red = Color.FromArgb(220, 53, 69);
        Color gray = Color.FromArgb(180, 180, 180);

        SetRoundedButton(
            btnCheckStatus,
            8,
            maroon);

        SetRoundedButton(
            btnAdd,
            8,
            maroon);

        SetRoundedButton(
            btnUpdate,
            8,
            gray);

        SetRoundedButton(
            btnDelete,
            8,
            red);

        SetRoundedButton(
            btnClear,
            8,
            maroon);

        SetRoundedButton(
            btnRefresh,
            8,
            maroon);

        SetRoundedButton(
            btnSearch,
            8,
            maroon);
    }

    // ==========================================
    // FORM LOAD
    // ==========================================

    private async void Form_Load(
        object? sender,
        EventArgs e)
    {
        try
        {
            await LoadStudents();

            ConfigureGrid();

            await LoadGrid();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to load Student Clearances.\n\n{ex.Message}",
                "Load Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // ==========================================
    // LOAD STUDENTS
    // ==========================================

    private async Task LoadStudents()
    {
        List<Student> students =
            await _students.GetAllAsync();

        cmbStudent.DataSource =
            null;

        cmbStudent.DataSource =
            students
                .Where(x =>
                    x.Status.Equals(
                        "Active",
                        StringComparison.OrdinalIgnoreCase))
                .OrderBy(x =>
                    x.FullName)
                .ToList();

        cmbStudent.DisplayMember =
            "FullName";
    }

    // ==========================================
    // CONFIGURE GRID
    // ==========================================

    private void ConfigureGrid()
    {
        dgvClearances.AutoGenerateColumns =
            false;

        dgvClearances.Columns.Clear();

        dgvClearances.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ClearanceId",
                HeaderText = "Clearance ID",
                Name = "colClearanceId"
            });

        dgvClearances.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentId",
                HeaderText = "Student ID",
                Name = "colStudentId"
            });

        dgvClearances.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LibraryStatus",
                HeaderText = "Library Status",
                Name = "colLibraryStatus"
            });

        dgvClearances.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MedicalStatus",
                HeaderText = "Medical Status",
                Name = "colMedicalStatus"
            });

        dgvClearances.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RegistrarStatus",
                HeaderText = "Registrar Status",
                Name = "colRegistrarStatus"
            });

        dgvClearances.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AccountingStatus",
                HeaderText = "Accounting Status",
                Name = "colAccountingStatus"
            });

        dgvClearances.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OverallStatus",
                HeaderText = "Overall Status",
                Name = "colOverallStatus"
            });

        dgvClearances.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Remarks",
                HeaderText = "Remarks",
                Name = "colRemarks"
            });

        dgvClearances.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdatedAt",
                HeaderText = "Updated At",
                Name = "colUpdatedAt"
            });
    }

    // ==========================================
    // CHECK SHARED STATUS
    // ==========================================

    private async void btnCheckStatus_Click(
        object? sender,
        EventArgs e)
    {
        if (cmbStudent.SelectedItem
            is not Student student)
        {
            MessageBox.Show(
                "Please select a student.",
                "Student Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        try
        {
            // --------------------------
            // LIBRARY STATUS
            // --------------------------

            var library =
                await _service.GetLibraryAsync(
                    student.StudentId);

            txtLibraryStatus.Text =
                library?.LibraryStatus
                ?? "No Record";

            // --------------------------
            // MEDICAL STATUS
            // --------------------------

            var medical =
                await _service.GetMedicalAsync(
                    student.StudentId);

            txtMedicalStatus.Text =
                medical?.MedicalStatus
                ?? "No Record";

            // --------------------------
            // REGISTRAR STATUS
            // Automatically computed.
            // --------------------------

            string registrarStatus =
                await _service.GetRegistrarStatusAsync(
                    student.StudentId);

            cmbRegistrarStatus.SelectedItem =
                registrarStatus;

            // --------------------------
            // ACCOUNTING STATUS
            // Automatically computed.
            // --------------------------

            string accountingStatus =
                await _service.GetAccountingStatusAsync(
                    student.StudentId);

            cmbAccountingStatus.SelectedItem =
                accountingStatus;

            // --------------------------
            // OVERALL STATUS
            // --------------------------

            UpdateOverallStatus();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to check shared status.\n\n{ex.Message}",
                "Check Status Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // ==========================================
    // BUILD CLEARANCE
    // ==========================================

    private StudentClearance Build(
        string id)
    {
        StudentClearance clearance =
            new StudentClearance
            {
                ClearanceId =
                    id,

                StudentId =
                    (cmbStudent.SelectedItem as Student)
                        ?.StudentId
                    ?? "",

                LibraryStatus =
                    txtLibraryStatus.Text.Trim(),

                MedicalStatus =
                    txtMedicalStatus.Text.Trim(),

                RegistrarStatus =
                    cmbRegistrarStatus.Text,

                AccountingStatus =
                    cmbAccountingStatus.Text,

                Remarks =
                    txtRemarks.Text.Trim(),

                UpdatedAt =
                    DateTime.Now.ToString(
                        "yyyy-MM-dd HH:mm:ss")
            };

        clearance.OverallStatus =
            ClearanceService.Overall(
                clearance);

        txtOverallStatus.Text =
            clearance.OverallStatus;

        return clearance;
    }

    // ==========================================
    // UPDATE OVERALL STATUS
    // ==========================================

    private void UpdateOverallStatus()
    {
        StudentClearance clearance =
            new StudentClearance
            {
                LibraryStatus =
                    txtLibraryStatus.Text.Trim(),

                MedicalStatus =
                    txtMedicalStatus.Text.Trim(),

                RegistrarStatus =
                    cmbRegistrarStatus.Text,

                AccountingStatus =
                    cmbAccountingStatus.Text
            };

        txtOverallStatus.Text =
            ClearanceService.Overall(
                clearance);
    }

    // ==========================================
    // ADD
    // ==========================================

    private async void btnAdd_Click(
        object? sender,
        EventArgs e)
    {
        if (cmbStudent.SelectedItem
            is not Student student)
        {
            MessageBox.Show(
                "Please select a student.",
                "Student Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        if (string.IsNullOrWhiteSpace(
                txtLibraryStatus.Text) ||
            string.IsNullOrWhiteSpace(
                txtMedicalStatus.Text) ||
            string.IsNullOrWhiteSpace(
                cmbRegistrarStatus.Text) ||
            string.IsNullOrWhiteSpace(
                cmbAccountingStatus.Text))
        {
            MessageBox.Show(
                "Please click Check Shared Status first.",
                "Check Status Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        try
        {
            List<StudentClearance> existingRecords =
                await _service.GetAllAsync();

            bool alreadyExists =
                existingRecords.Any(x =>
                    x.StudentId.Equals(
                        student.StudentId,
                        StringComparison.OrdinalIgnoreCase));

            if (alreadyExists)
            {
                MessageBox.Show(
                    "A clearance record already exists for this student.",
                    "Duplicate Record",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string newId =
                IdGenerator.CreateNext(
                    "CLR",
                    existingRecords.Select(
                        x => x.ClearanceId));

            StudentClearance clearance =
                Build(newId);

            await _service.SaveAsync(
                clearance);

            await LoadGrid();

            Clear();

            MessageBox.Show(
                "Clearance record added successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to add clearance record.\n\n{ex.Message}",
                "Add Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // ==========================================
    // UPDATE
    // ==========================================

    private async void btnUpdate_Click(
        object? sender,
        EventArgs e)
    {
        if (_id == null)
        {
            return;
        }

        try
        {
            StudentClearance clearance =
                Build(_id);

            await _service.SaveAsync(
                clearance);

            await LoadGrid();

            MessageBox.Show(
                "Clearance record updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to update clearance record.\n\n{ex.Message}",
                "Update Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // ==========================================
    // DELETE
    // ==========================================

    private async void btnDelete_Click(
        object? sender,
        EventArgs e)
    {
        if (_id == null)
        {
            return;
        }

        DialogResult result =
            MessageBox.Show(
                "Are you sure you want to delete this clearance record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

        if (result != DialogResult.Yes)
        {
            return;
        }

        try
        {
            await _service.DeleteAsync(
                _id);

            await LoadGrid();

            Clear();

            MessageBox.Show(
                "Clearance record deleted successfully.",
                "Deleted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to delete clearance record.\n\n{ex.Message}",
                "Delete Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // ==========================================
    // CLEAR
    // ==========================================

    private void btnClear_Click(
        object? sender,
        EventArgs e)
    {
        Clear();
    }

    // ==========================================
    // REFRESH
    // ==========================================

    private async void btnRefresh_Click(
        object? sender,
        EventArgs e)
    {
        try
        {
            await LoadStudents();

            await LoadGrid();

            Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to refresh records.\n\n{ex.Message}",
                "Refresh Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // ==========================================
    // SEARCH
    // ==========================================

    private async void btnSearch_Click(
        object? sender,
        EventArgs e)
    {
        try
        {
            string search =
                txtSearch.Text
                    .Trim()
                    .ToLowerInvariant();

            List<StudentClearance> records =
                await _service.GetAllAsync();

            if (string.IsNullOrWhiteSpace(search))
            {
                dgvClearances.DataSource =
                    records;

                return;
            }

            dgvClearances.DataSource =
                records
                    .Where(x =>
                        x.ClearanceId
                            .ToLowerInvariant()
                            .Contains(search)
                        ||
                        x.StudentId
                            .ToLowerInvariant()
                            .Contains(search))
                    .ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Search failed.\n\n{ex.Message}",
                "Search Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // ==========================================
    // LOAD GRID
    // ==========================================

    private async Task LoadGrid()
    {
        dgvClearances.DataSource =
            null;

        dgvClearances.DataSource =
            await _service.GetAllAsync();
    }

    // ==========================================
    // GRID CLICK
    // ==========================================

    private void dgvClearances_CellClick(
        object? sender,
        DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        if (dgvClearances
                .Rows[e.RowIndex]
                .DataBoundItem
            is not StudentClearance clearance)
        {
            return;
        }

        _id =
            clearance.ClearanceId;

        txtLibraryStatus.Text =
            clearance.LibraryStatus;

        txtMedicalStatus.Text =
            clearance.MedicalStatus;

        cmbRegistrarStatus.Text =
            clearance.RegistrarStatus;

        cmbAccountingStatus.Text =
            clearance.AccountingStatus;

        txtOverallStatus.Text =
            clearance.OverallStatus;

        txtRemarks.Text =
            clearance.Remarks;

        SelectStudent(
            clearance.StudentId);

        cmbStudent.Enabled =
            false;

        btnUpdate.Enabled =
            true;

        btnDelete.Enabled =
            true;
    }

    // ==========================================
    // SELECT STUDENT
    // ==========================================

    private void SelectStudent(
        string studentId)
    {
        for (int i = 0;
             i < cmbStudent.Items.Count;
             i++)
        {
            if ((cmbStudent.Items[i]
                    as Student)
                    ?.StudentId
                == studentId)
            {
                cmbStudent.SelectedIndex =
                    i;

                break;
            }
        }
    }

    // ==========================================
    // RESET FORM
    // ==========================================

    private void Clear()
    {
        _id =
            null;

        txtLibraryStatus.Clear();

        txtMedicalStatus.Clear();

        txtOverallStatus.Clear();

        txtRemarks.Clear();

        cmbRegistrarStatus.SelectedIndex =
            -1;

        cmbAccountingStatus.SelectedIndex =
            -1;

        cmbStudent.Enabled =
            true;

        btnUpdate.Enabled =
            false;

        btnDelete.Enabled =
            false;
    }

    // ==========================================
    // BACK
    // ==========================================

    private void btnBack_Click(
        object? sender,
        EventArgs e)
    {
        Close();
    }

    // ==========================================
    // ROUNDED BUTTON DESIGN
    // ==========================================

    private GraphicsPath GetRoundedPath(
        Rectangle rectangle,
        int radius)
    {
        GraphicsPath path =
            new GraphicsPath();

        int diameter =
            radius * 2;

        path.AddArc(
            rectangle.X,
            rectangle.Y,
            diameter,
            diameter,
            180,
            90);

        path.AddArc(
            rectangle.Right - diameter,
            rectangle.Y,
            diameter,
            diameter,
            270,
            90);

        path.AddArc(
            rectangle.Right - diameter,
            rectangle.Bottom - diameter,
            diameter,
            diameter,
            0,
            90);

        path.AddArc(
            rectangle.X,
            rectangle.Bottom - diameter,
            diameter,
            diameter,
            90,
            90);

        path.CloseFigure();

        return path;
    }

    private void SetRoundedButton(
        Button button,
        int radius,
        Color borderColor)
    {
        button.FlatStyle =
            FlatStyle.Flat;

        button.FlatAppearance.BorderSize =
            0;

        void ApplyRegion()
        {
            Rectangle rectangle =
                new Rectangle(
                    0,
                    0,
                    button.Width,
                    button.Height);

            using GraphicsPath path =
                GetRoundedPath(
                    rectangle,
                    radius);

            button.Region?.Dispose();

            button.Region =
                new Region(path);
        }

        button.Paint +=
            (sender, e) =>
            {
                e.Graphics.SmoothingMode =
                    SmoothingMode.AntiAlias;

                Rectangle rectangle =
                    new Rectangle(
                        1,
                        1,
                        button.Width - 3,
                        button.Height - 3);

                using GraphicsPath path =
                    GetRoundedPath(
                        rectangle,
                        radius);

                using Pen pen =
                    new Pen(
                        borderColor,
                        1.5F);

                e.Graphics.DrawPath(
                    pen,
                    path);
            };

        button.Resize +=
            (sender, e) =>
                ApplyRegion();

        ApplyRegion();
    }
}