using RegistrarManagement.Helpers;
using RegistrarManagement.Models;
using RegistrarManagement.Services;
using System.Drawing.Drawing2D;

namespace RegistrarManagement.Forms;

public partial class DocumentRequestsForm : Form
{
    private readonly DocumentRequestService _service = new();
    private readonly StudentService _students = new();

    private string? _selectedRequestId;
    private bool _isLoadingRecord;

    public DocumentRequestsForm()
    {
        InitializeComponent();

        Color maroon = Color.FromArgb(128, 0, 24);
        Color red = Color.FromArgb(220, 53, 69);
        Color gray = Color.FromArgb(180, 180, 180);

        SetRoundedButton(btnAdd, 10, maroon);
        SetRoundedButton(btnUpdate, 10, gray);
        SetRoundedButton(btnDelete, 10, red);
        SetRoundedButton(btnClear, 10, maroon);
        SetRoundedButton(btnRefresh, 10, maroon);
        SetRoundedButton(btnSearch, 8, maroon);

        Load += Form_Load;

        cmbStatus.SelectedIndexChanged +=
            cmbStatus_SelectedIndexChanged;

        cmbDocumentType.Items.AddRange(
        [
            "Certificate of Enrollment",
            "Certificate of Registration",
            "Transcript of Records",
            "Certificate of Grades",
            "Good Moral Certificate",
            "Honorable Dismissal",
            "Student Clearance",
            "Diploma",
            "Form 137",
            "Other"
        ]);

        cmbStatus.Items.AddRange(
        [
            "Pending",
            "Processing",
            "Ready for Release",
            "Released",
            "Rejected",
            "Cancelled"
        ]);
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
            Rectangle rectangle = new Rectangle(
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

    private async void Form_Load(
        object? sender,
        EventArgs e)
    {
        try
        {
            ConfigureReleaseDate();

            await LoadStudentsAsync();
            await LoadGridAsync();

            ClearFields();
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

    private void ConfigureReleaseDate()
    {
        dtpReleaseDate.ShowCheckBox = true;
        dtpReleaseDate.Checked = false;
        dtpReleaseDate.Enabled = false;
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

    private DocumentRequest BuildRequest(
        string requestId)
    {
        return new DocumentRequest
        {
            RequestId = requestId,

            StudentId =
                (cmbStudent.SelectedItem as Student)
                    ?.StudentId
                ?? string.Empty,

            DocumentType =
                cmbDocumentType.Text.Trim(),

            Purpose =
                txtPurpose.Text.Trim(),

            RequestDate =
                dtpRequestDate.Value
                    .ToString("yyyy-MM-dd"),

            Status =
                cmbStatus.Text.Trim(),

            ReleaseDate =
                dtpReleaseDate.Checked
                    ? dtpReleaseDate.Value
                        .ToString("yyyy-MM-dd")
                    : string.Empty,

            Remarks =
                txtRemarks.Text.Trim()
        };
    }

    private bool IsFormValid()
    {
        if (cmbStudent.SelectedItem == null)
        {
            MessageBox.Show(
                "Select a student.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return false;
        }

        if (!ValidationHelper.Required(
            cmbDocumentType.Text,
            txtPurpose.Text,
            cmbStatus.Text
        ))
        {
            MessageBox.Show(
                "Complete all required fields.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return false;
        }

        if (cmbStatus.Text.Equals(
            "Released",
            StringComparison.OrdinalIgnoreCase
        )
        && !dtpReleaseDate.Checked)
        {
            MessageBox.Show(
                "Release Date is required when the status is Released.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return false;
        }

        return true;
    }

    private void cmbStatus_SelectedIndexChanged(
        object? sender,
        EventArgs e)
    {
        if (_isLoadingRecord)
        {
            return;
        }

        string status =
            cmbStatus.Text.Trim();

        bool isReleased =
            status.Equals(
                "Released",
                StringComparison.OrdinalIgnoreCase
            );

        dtpReleaseDate.Enabled =
            isReleased;

        if (isReleased)
        {
            dtpReleaseDate.Checked = true;
            dtpReleaseDate.Value = DateTime.Now;
        }
        else
        {
            dtpReleaseDate.Checked = false;
        }
    }

    private async void btnAdd_Click(
        object? sender,
        EventArgs e)
    {
        try
        {
            if (!IsFormValid())
            {
                return;
            }

            DocumentRequest request =
                BuildRequest(
                    IdGenerator.Create("REQ")
                );

            await _service.SaveAsync(
                request
            );

            await LoadGridAsync();

            ClearFields();

            MessageBox.Show(
                "Document request saved to Firebase.",
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
        if (_selectedRequestId == null)
        {
            MessageBox.Show(
                "Select a document request first.",
                "Update",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        if (!IsFormValid())
        {
            return;
        }

        try
        {
            DocumentRequest request =
                BuildRequest(
                    _selectedRequestId
                );

            await _service.SaveAsync(
                request
            );

            await LoadGridAsync();

            ClearFields();

            MessageBox.Show(
                "Document request updated.",
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
        if (_selectedRequestId == null)
        {
            MessageBox.Show(
                "Select a document request first.",
                "Delete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        DialogResult result =
            MessageBox.Show(
                "Delete the selected document request?",
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
                _selectedRequestId
            );

            await LoadGridAsync();

            ClearFields();

            MessageBox.Show(
                "Document request deleted.",
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
            await LoadStudentsAsync();
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

            List<DocumentRequest> requests =
                await _service.GetAllAsync();

            if (string.IsNullOrWhiteSpace(
                searchText))
            {
                dgvDocumentRequests.DataSource =
                    requests;

                dgvDocumentRequests
                    .ClearSelection();

                return;
            }

            dgvDocumentRequests.DataSource =
                requests
                    .Where(request =>
                        request.RequestId
                            .ToLowerInvariant()
                            .Contains(searchText)

                        || request.StudentId
                            .ToLowerInvariant()
                            .Contains(searchText)

                        || request.DocumentType
                            .ToLowerInvariant()
                            .Contains(searchText)

                        || request.Status
                            .ToLowerInvariant()
                            .Contains(searchText)
                    )
                    .ToList();

            dgvDocumentRequests
                .ClearSelection();
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
        dgvDocumentRequests.DataSource =
            await _service.GetAllAsync();

        dgvDocumentRequests
            .ClearSelection();
    }

    private void dgvDocumentRequests_CellClick(
        object? sender,
        DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        object? selectedItem =
            dgvDocumentRequests
                .Rows[e.RowIndex]
                .DataBoundItem;

        if (selectedItem
            is not DocumentRequest request)
        {
            return;
        }

        _isLoadingRecord = true;

        try
        {
            _selectedRequestId =
                request.RequestId;

            SelectStudent(
                request.StudentId
            );

            cmbDocumentType.Text =
                request.DocumentType;

            txtPurpose.Text =
                request.Purpose;

            cmbStatus.Text =
                request.Status;

            txtRemarks.Text =
                request.Remarks;

            if (DateTime.TryParse(
                request.RequestDate,
                out DateTime requestDate
            ))
            {
                dtpRequestDate.Value =
                    requestDate;
            }

            if (DateTime.TryParse(
                request.ReleaseDate,
                out DateTime releaseDate
            ))
            {
                dtpReleaseDate.Checked = true;

                dtpReleaseDate.Value =
                    releaseDate;
            }
            else
            {
                dtpReleaseDate.Checked = false;
                dtpReleaseDate.Value = DateTime.Now;
            }

            dtpReleaseDate.Enabled =
                request.Status.Equals(
                    "Released",
                    StringComparison.OrdinalIgnoreCase
                );

            cmbStudent.Enabled = false;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        finally
        {
            _isLoadingRecord = false;
        }
    }

    private void SelectStudent(
        string studentId)
    {
        cmbStudent.SelectedIndex = -1;

        for (int index = 0;
             index < cmbStudent.Items.Count;
             index++)
        {
            if (cmbStudent.Items[index]
                    is Student student
                && student.StudentId.Equals(
                    studentId,
                    StringComparison.OrdinalIgnoreCase
                ))
            {
                cmbStudent.SelectedIndex =
                    index;

                return;
            }
        }
    }

    private void ClearFields()
    {
        _isLoadingRecord = true;

        try
        {
            _selectedRequestId = null;

            cmbStudent.Enabled = true;

            cmbStudent.SelectedIndex = -1;

            cmbDocumentType.SelectedIndex = -1;

            cmbStatus.SelectedIndex = -1;
            cmbStatus.Text = "Pending";

            txtPurpose.Clear();
            txtRemarks.Clear();
            txtSearch.Clear();

            dtpRequestDate.Value =
                DateTime.Now;

            dtpReleaseDate.Checked =
                false;

            dtpReleaseDate.Value =
                DateTime.Now;

            dtpReleaseDate.Enabled =
                false;

            btnUpdate.Enabled =
                false;

            btnDelete.Enabled =
                false;

            dgvDocumentRequests
                .ClearSelection();
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
}