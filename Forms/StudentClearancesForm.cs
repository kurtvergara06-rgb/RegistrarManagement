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
    private bool _sortAscending = false;

    private List<Student> _activeStudents = [];
    private List<StudentClearance> _savedClearances = [];

    public StudentClearancesForm()
    {
        InitializeComponent();

        Load += Form_Load;

        cmbRegistrarStatus.Items.AddRange(new[]
        {
            "Cleared",
            "Pending",
            "Not Cleared",
            "No Record"
        });

        cmbRegistrarStatus.Enabled = false;

        cmbAccountingStatus.Items.AddRange(new[]
        {
            "Cleared",
            "Not Cleared",
            "No Record"
        });

        cmbAccountingStatus.Enabled = false;

        cmbfilter.Items.Clear();
        cmbfilter.Items.AddRange(new[]
        {
            "All Statuses",
            "Cleared",
            "Pending",
            "Not Cleared",
            "No Record"
        });
        cmbfilter.SelectedIndex = 0;

        btnsort.Text = "Sort: Z-A";
        btnsort.Enabled = true;

        Color maroon = Color.FromArgb(128, 0, 24);
        Color red = Color.FromArgb(220, 53, 69);
        Color gray = Color.FromArgb(180, 180, 180);

        SetRoundedButton(btnCheckStatus, 8, maroon);
        SetRoundedButton(btnAdd, 8, maroon);
        SetRoundedButton(btnUpdate, 8, gray);
        SetRoundedButton(btnDelete, 8, red);
        SetRoundedButton(btnClear, 8, maroon);
        SetRoundedButton(btnRefresh, 8, maroon);
        SetRoundedButton(btnSearch, 8, maroon);
        SetRoundedButton(btnsort, 8, maroon);
    }

    private async void Form_Load(
        object? sender,
        EventArgs e)
    {
        try
        {
            await LoadStudents();
            ConfigureGrid();
            await ReloadAllDataAsync();
            Clear();
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

    private async Task ReloadAllDataAsync()
    {
        _savedClearances = await _service.GetAllAsync();
        await LoadGridRowsAsync();
    }

    private async Task LoadStudents()
    {
        List<Student> students =
            await _students.GetAllAsync();

        _activeStudents =
            students
                .Where(x =>
                    x.Status.Equals(
                        "Active",
                        StringComparison.OrdinalIgnoreCase))
                .OrderBy(x => x.FullName)
                .ToList();

        cmbStudent.DataSource = null;
        cmbStudent.DataSource = _activeStudents;
        cmbStudent.DisplayMember = "FullName";
        cmbStudent.ValueMember = "StudentId";
        cmbStudent.SelectedIndex = -1;
    }

    private void ConfigureGrid()
    {
        dgvClearances.AutoGenerateColumns = false;
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
                DataPropertyName = "StudentName",
                HeaderText = "Student Name",
                Name = "colStudentName"
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

    private async Task LoadGridRowsAsync()
    {
        List<StudentClearanceGridRow> rows =
            _activeStudents
                .Select(student =>
                {
                    StudentClearance? clearance =
                        _savedClearances.FirstOrDefault(x =>
                            x.StudentId.Equals(
                                student.StudentId,
                                StringComparison.OrdinalIgnoreCase));

                    return new StudentClearanceGridRow
                    {
                        ClearanceId = clearance?.ClearanceId ?? "",
                        StudentId = student.StudentId,
                        StudentName = student.FullName,
                        LibraryStatus = clearance?.LibraryStatus ?? "No Record",
                        MedicalStatus = clearance?.MedicalStatus ?? "No Record",
                        RegistrarStatus = clearance?.RegistrarStatus ?? "No Record",
                        AccountingStatus = clearance?.AccountingStatus ?? "No Record",
                        OverallStatus = clearance?.OverallStatus ?? "Pending",
                        Remarks = clearance?.Remarks ?? "",
                        UpdatedAt = clearance?.UpdatedAt ?? ""
                    };
                })
                .ToList();

        string searchText =
            txtSearch.Text.Trim().ToLowerInvariant();

        string selectedFilter =
            cmbfilter.SelectedItem?.ToString()
            ?? "All Statuses";

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            rows = rows
                .Where(row =>
                    row.StudentId.ToLowerInvariant().Contains(searchText)
                    || row.StudentName.ToLowerInvariant().Contains(searchText)
                    || row.ClearanceId.ToLowerInvariant().Contains(searchText)
                    || row.OverallStatus.ToLowerInvariant().Contains(searchText))
                .ToList();
        }

        if (!selectedFilter.Equals(
                "All Statuses",
                StringComparison.OrdinalIgnoreCase))
        {
            rows = rows
                .Where(row =>
                    row.OverallStatus.Equals(
                        selectedFilter,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        rows = _sortAscending
            ? rows.OrderBy(row => row.StudentName).ToList()
            : rows.OrderByDescending(row => row.StudentName).ToList();

        dgvClearances.DataSource = null;
        dgvClearances.DataSource = rows;

        await Task.CompletedTask;
    }

    private async void btnCheckStatus_Click(
        object? sender,
        EventArgs e)
    {
        if (cmbStudent.SelectedItem is not Student student)
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
            var library =
                await _service.GetLibraryAsync(student.StudentId);

            txtLibraryStatus.Text =
                library?.LibraryStatus ?? "No Record";

            var medical =
                await _service.GetMedicalAsync(student.StudentId);

            txtMedicalStatus.Text =
                medical?.MedicalStatus ?? "No Record";

            string registrarStatus =
                await _service.GetRegistrarStatusAsync(student.StudentId);

            cmbRegistrarStatus.SelectedItem = registrarStatus;

            string accountingStatus =
                await _service.GetAccountingStatusAsync(student.StudentId);

            cmbAccountingStatus.SelectedItem = accountingStatus;

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

    private StudentClearance Build(string id)
    {
        StudentClearance clearance =
            new StudentClearance
            {
                ClearanceId = id,
                StudentId =
                    (cmbStudent.SelectedItem as Student)?.StudentId ?? "",
                LibraryStatus = txtLibraryStatus.Text.Trim(),
                MedicalStatus = txtMedicalStatus.Text.Trim(),
                RegistrarStatus = cmbRegistrarStatus.Text,
                AccountingStatus = cmbAccountingStatus.Text,
                Remarks = txtRemarks.Text.Trim(),
                UpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

        clearance.OverallStatus =
            ClearanceService.Overall(clearance);

        txtOverallStatus.Text =
            clearance.OverallStatus;

        return clearance;
    }

    private void UpdateOverallStatus()
    {
        StudentClearance clearance =
            new StudentClearance
            {
                LibraryStatus = txtLibraryStatus.Text.Trim(),
                MedicalStatus = txtMedicalStatus.Text.Trim(),
                RegistrarStatus = cmbRegistrarStatus.Text,
                AccountingStatus = cmbAccountingStatus.Text
            };

        txtOverallStatus.Text =
            ClearanceService.Overall(clearance);
    }

    private async void btnAdd_Click(
        object? sender,
        EventArgs e)
    {
        if (cmbStudent.SelectedItem is not Student student)
        {
            MessageBox.Show(
                "Please select a student.",
                "Student Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtLibraryStatus.Text) ||
            string.IsNullOrWhiteSpace(txtMedicalStatus.Text) ||
            string.IsNullOrWhiteSpace(cmbRegistrarStatus.Text) ||
            string.IsNullOrWhiteSpace(cmbAccountingStatus.Text))
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
            bool alreadyExists =
                _savedClearances.Any(x =>
                    x.StudentId.Equals(
                        student.StudentId,
                        StringComparison.OrdinalIgnoreCase));

            if (alreadyExists)
            {
                MessageBox.Show(
                    "A clearance record already exists for this student. Please use Update instead.",
                    "Duplicate Record",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult addConfirm =
                MessageBox.Show(
                    "Save this clearance record?",
                    "Confirm Add",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (addConfirm != DialogResult.Yes)
            {
                return;
            }

            string newId =
                IdGenerator.CreateNext(
                    "CLR",
                    _savedClearances.Select(x => x.ClearanceId));

            StudentClearance clearance = Build(newId);

            await _service.SaveAsync(clearance);

            await ReloadAllDataAsync();
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

    private async void btnUpdate_Click(
        object? sender,
        EventArgs e)
    {
        if (_id == null)
        {
            MessageBox.Show(
                "Please select an existing clearance row first.",
                "Update",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        try
        {
            DialogResult updateConfirm =
                MessageBox.Show(
                    "Update this clearance record?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (updateConfirm != DialogResult.Yes)
            {
                return;
            }

            StudentClearance clearance = Build(_id);

            await _service.SaveAsync(clearance);
            await ReloadAllDataAsync();

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

    private async void btnDelete_Click(
        object? sender,
        EventArgs e)
    {
        if (_id == null)
        {
            MessageBox.Show(
                "Please select an existing clearance row first.",
                "Delete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
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
            await _service.DeleteAsync(_id);

            await ReloadAllDataAsync();
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

    private void btnClear_Click(
        object? sender,
        EventArgs e)
    {
        Clear();
    }

    private async void btnRefresh_Click(
        object? sender,
        EventArgs e)
    {
        try
        {
            await LoadStudents();
            await ReloadAllDataAsync();

            cmbfilter.SelectedIndex = 0;
            _sortAscending = false;
            btnsort.Text = "Sort: Z-A";

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

    private async void btnSearch_Click(
        object? sender,
        EventArgs e)
    {
        try
        {
            await LoadGridRowsAsync();
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

    private async Task LoadGrid()
    {
        await LoadGridRowsAsync();
    }

    private void dgvClearances_CellClick(
        object? sender,
        DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        if (dgvClearances.Rows[e.RowIndex].DataBoundItem
            is not StudentClearanceGridRow row)
        {
            return;
        }

        SelectStudent(row.StudentId);

        StudentClearance? existing =
            _savedClearances.FirstOrDefault(x =>
                x.StudentId.Equals(
                    row.StudentId,
                    StringComparison.OrdinalIgnoreCase));

        if (existing == null)
        {
            _id = null;

            txtLibraryStatus.Text = "No Record";
            txtMedicalStatus.Text = "No Record";
            cmbRegistrarStatus.Text = "No Record";
            cmbAccountingStatus.Text = "No Record";
            txtOverallStatus.Text = "Pending";
            txtRemarks.Clear();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        else
        {
            _id = existing.ClearanceId;

            txtLibraryStatus.Text = existing.LibraryStatus;
            txtMedicalStatus.Text = existing.MedicalStatus;
            cmbRegistrarStatus.Text = existing.RegistrarStatus;
            cmbAccountingStatus.Text = existing.AccountingStatus;
            txtOverallStatus.Text = existing.OverallStatus;
            txtRemarks.Text = existing.Remarks;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        cmbStudent.Enabled = true;
    }

    private void SelectStudent(string studentId)
    {
        for (int i = 0; i < cmbStudent.Items.Count; i++)
        {
            if ((cmbStudent.Items[i] as Student)?.StudentId == studentId)
            {
                cmbStudent.SelectedIndex = i;
                break;
            }
        }
    }

    private void Clear()
    {
        _id = null;

        txtLibraryStatus.Clear();
        txtMedicalStatus.Clear();
        txtOverallStatus.Clear();
        txtRemarks.Clear();

        cmbRegistrarStatus.SelectedIndex = -1;
        cmbAccountingStatus.SelectedIndex = -1;

        cmbStudent.Enabled = true;
        cmbStudent.SelectedIndex = -1;

        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;
    }

    private void btnBack_Click(
        object? sender,
        EventArgs e)
    {
        Close();
    }

    private GraphicsPath GetRoundedPath(
        Rectangle rectangle,
        int radius)
    {
        GraphicsPath path = new GraphicsPath();

        int diameter = radius * 2;

        path.AddArc(rectangle.X, rectangle.Y, diameter, diameter, 180, 90);
        path.AddArc(rectangle.Right - diameter, rectangle.Y, diameter, diameter, 270, 90);
        path.AddArc(rectangle.Right - diameter, rectangle.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rectangle.X, rectangle.Bottom - diameter, diameter, diameter, 90, 90);

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
                    button.Height);

            using GraphicsPath path =
                GetRoundedPath(rectangle, radius);

            button.Region?.Dispose();
            button.Region = new Region(path);
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
                    GetRoundedPath(rectangle, radius);

                using Pen pen =
                    new Pen(borderColor, 1.5F);

                e.Graphics.DrawPath(pen, path);
            };

        button.Resize +=
            (sender, e) => ApplyRegion();

        ApplyRegion();
    }

    private async void btnsort_Click(object sender, EventArgs e)
    {
        _sortAscending = !_sortAscending;

        btnsort.Text = _sortAscending
            ? "Sort: A-Z"
            : "Sort: Z-A";

        await LoadGridRowsAsync();
    }

    private async void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        await LoadGridRowsAsync();
    }

    private sealed class StudentClearanceGridRow
    {
        public string ClearanceId { get; set; } = "";
        public string StudentId { get; set; } = "";
        public string StudentName { get; set; } = "";
        public string LibraryStatus { get; set; } = "";
        public string MedicalStatus { get; set; } = "";
        public string RegistrarStatus { get; set; } = "";
        public string AccountingStatus { get; set; } = "";
        public string OverallStatus { get; set; } = "";
        public string Remarks { get; set; } = "";
        public string UpdatedAt { get; set; } = "";
    }

    private void pnlFormCard_Paint(object sender, PaintEventArgs e)
    {
    }
}