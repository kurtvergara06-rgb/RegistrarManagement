namespace RegistrarManagement.Forms;

partial class DocumentRequestsForm
{
    private System.ComponentModel.IContainer? components = null;

    private Label lblTitle = null!;

    private Label lblStudent = null!;
    private ComboBox cmbStudent = null!;

    private Label lblDocumentType = null!;
    private ComboBox cmbDocumentType = null!;

    private Label lblPurpose = null!;
    private TextBox txtPurpose = null!;

    private Label lblRequestDate = null!;
    private DateTimePicker dtpRequestDate = null!;

    private Label lblStatus = null!;
    private ComboBox cmbStatus = null!;

    private Label lblReleaseDate = null!;
    private DateTimePicker dtpReleaseDate = null!;

    private Label lblRemarks = null!;
    private TextBox txtRemarks = null!;

    private Button btnAdd = null!;
    private Button btnUpdate = null!;
    private Button btnDelete = null!;
    private Button btnClear = null!;
    private Button btnRefresh = null!;

    private Label lblSearch = null!;
    private TextBox txtSearch = null!;
    private Button btnSearch = null!;

    private DataGridView dgvDocumentRequests = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        lblTitle = new Label();
        lblStudent = new Label();
        cmbStudent = new ComboBox();
        lblDocumentType = new Label();
        cmbDocumentType = new ComboBox();
        lblPurpose = new Label();
        txtPurpose = new TextBox();
        lblRequestDate = new Label();
        dtpRequestDate = new DateTimePicker();
        lblStatus = new Label();
        cmbStatus = new ComboBox();
        lblReleaseDate = new Label();
        dtpReleaseDate = new DateTimePicker();
        lblRemarks = new Label();
        txtRemarks = new TextBox();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        btnRefresh = new Button();
        lblSearch = new Label();
        txtSearch = new TextBox();
        btnSearch = new Button();
        dgvDocumentRequests = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvDocumentRequests).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(25, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(242, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Document Requests";
        // 
        // lblStudent
        // 
        lblStudent.AutoSize = true;
        lblStudent.Location = new Point(28, 75);
        lblStudent.Name = "lblStudent";
        lblStudent.Size = new Size(48, 15);
        lblStudent.TabIndex = 1;
        lblStudent.Text = "Student";
        // 
        // cmbStudent
        // 
        cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStudent.FormattingEnabled = true;
        cmbStudent.Location = new Point(140, 70);
        cmbStudent.Name = "cmbStudent";
        cmbStudent.Size = new Size(390, 23);
        cmbStudent.TabIndex = 2;
        // 
        // lblDocumentType
        // 
        lblDocumentType.AutoSize = true;
        lblDocumentType.Location = new Point(585, 75);
        lblDocumentType.Name = "lblDocumentType";
        lblDocumentType.Size = new Size(91, 15);
        lblDocumentType.TabIndex = 3;
        lblDocumentType.Text = "Document Type";
        // 
        // cmbDocumentType
        // 
        cmbDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDocumentType.FormattingEnabled = true;
        cmbDocumentType.Location = new Point(695, 70);
        cmbDocumentType.Name = "cmbDocumentType";
        cmbDocumentType.Size = new Size(430, 23);
        cmbDocumentType.TabIndex = 4;
        // 
        // lblPurpose
        // 
        lblPurpose.AutoSize = true;
        lblPurpose.Location = new Point(28, 117);
        lblPurpose.Name = "lblPurpose";
        lblPurpose.Size = new Size(50, 15);
        lblPurpose.TabIndex = 5;
        lblPurpose.Text = "Purpose";
        // 
        // txtPurpose
        // 
        txtPurpose.Location = new Point(140, 112);
        txtPurpose.Name = "txtPurpose";
        txtPurpose.Size = new Size(390, 23);
        txtPurpose.TabIndex = 6;
        // 
        // lblRequestDate
        // 
        lblRequestDate.AutoSize = true;
        lblRequestDate.Location = new Point(585, 117);
        lblRequestDate.Name = "lblRequestDate";
        lblRequestDate.Size = new Size(76, 15);
        lblRequestDate.TabIndex = 7;
        lblRequestDate.Text = "Request Date";
        // 
        // dtpRequestDate
        // 
        dtpRequestDate.Location = new Point(695, 112);
        dtpRequestDate.Name = "dtpRequestDate";
        dtpRequestDate.Size = new Size(430, 23);
        dtpRequestDate.TabIndex = 8;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(28, 159);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(39, 15);
        lblStatus.TabIndex = 9;
        lblStatus.Text = "Status";
        // 
        // cmbStatus
        // 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Location = new Point(140, 154);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(390, 23);
        cmbStatus.TabIndex = 10;
        // 
        // lblReleaseDate
        // 
        lblReleaseDate.AutoSize = true;
        lblReleaseDate.Location = new Point(585, 159);
        lblReleaseDate.Name = "lblReleaseDate";
        lblReleaseDate.Size = new Size(73, 15);
        lblReleaseDate.TabIndex = 11;
        lblReleaseDate.Text = "Release Date";
        // 
        // dtpReleaseDate
        // 
        dtpReleaseDate.Checked = false;
        dtpReleaseDate.Location = new Point(695, 154);
        dtpReleaseDate.Name = "dtpReleaseDate";
        dtpReleaseDate.ShowCheckBox = true;
        dtpReleaseDate.Size = new Size(430, 23);
        dtpReleaseDate.TabIndex = 12;
        // 
        // lblRemarks
        // 
        lblRemarks.AutoSize = true;
        lblRemarks.Location = new Point(28, 201);
        lblRemarks.Name = "lblRemarks";
        lblRemarks.Size = new Size(52, 15);
        lblRemarks.TabIndex = 13;
        lblRemarks.Text = "Remarks";
        // 
        // txtRemarks
        // 
        txtRemarks.Location = new Point(140, 196);
        txtRemarks.Name = "txtRemarks";
        txtRemarks.Size = new Size(390, 23);
        txtRemarks.TabIndex = 14;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(28, 244);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(95, 34);
        btnAdd.TabIndex = 15;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Enabled = false;
        btnUpdate.Location = new Point(133, 244);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(95, 34);
        btnUpdate.TabIndex = 16;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Enabled = false;
        btnDelete.Location = new Point(238, 244);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(95, 34);
        btnDelete.TabIndex = 17;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(343, 244);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(95, 34);
        btnClear.TabIndex = 18;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(448, 244);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(95, 34);
        btnRefresh.TabIndex = 19;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(28, 310);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(42, 15);
        lblSearch.TabIndex = 20;
        lblSearch.Text = "Search";
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(90, 305);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(360, 23);
        txtSearch.TabIndex = 21;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(460, 301);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(95, 32);
        btnSearch.TabIndex = 22;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // dgvDocumentRequests
        // 
        dgvDocumentRequests.AllowUserToAddRows = false;
        dgvDocumentRequests.AllowUserToDeleteRows = false;
        dgvDocumentRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvDocumentRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvDocumentRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvDocumentRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvDocumentRequests.DefaultCellStyle = dataGridViewCellStyle2;
        dgvDocumentRequests.Location = new Point(28, 350);
        dgvDocumentRequests.MultiSelect = false;
        dgvDocumentRequests.Name = "dgvDocumentRequests";
        dgvDocumentRequests.ReadOnly = true;
        dgvDocumentRequests.RowHeadersWidth = 51;
        dgvDocumentRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDocumentRequests.Size = new Size(1097, 330);
        dgvDocumentRequests.TabIndex = 23;
        dgvDocumentRequests.CellClick += dgvDocumentRequests_CellClick;
        // 
        // DocumentRequestsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1180, 720);
        Controls.Add(dgvDocumentRequests);
        Controls.Add(btnSearch);
        Controls.Add(txtSearch);
        Controls.Add(lblSearch);
        Controls.Add(btnRefresh);
        Controls.Add(btnClear);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnAdd);
        Controls.Add(txtRemarks);
        Controls.Add(lblRemarks);
        Controls.Add(dtpReleaseDate);
        Controls.Add(lblReleaseDate);
        Controls.Add(cmbStatus);
        Controls.Add(lblStatus);
        Controls.Add(dtpRequestDate);
        Controls.Add(lblRequestDate);
        Controls.Add(txtPurpose);
        Controls.Add(lblPurpose);
        Controls.Add(cmbDocumentType);
        Controls.Add(lblDocumentType);
        Controls.Add(cmbStudent);
        Controls.Add(lblStudent);
        Controls.Add(lblTitle);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(980, 620);
        Name = "DocumentRequestsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Document Requests";
        ((System.ComponentModel.ISupportInitialize)dgvDocumentRequests).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}