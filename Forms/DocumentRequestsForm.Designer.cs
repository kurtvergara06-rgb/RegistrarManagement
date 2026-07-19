namespace RegistrarManagement.Forms;

partial class DocumentRequestsForm
{
    private System.ComponentModel.IContainer? components = null;

    private Panel pnlHeader = null!;
    private Button btnBack = null!;
    private PictureBox picLogo = null!;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;

    private Panel pnlFormCard = null!;

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

    private Panel pnlSearch = null!;
    private Label lblSearch = null!;
    private TextBox txtSearch = null!;
    private Button btnSearch = null!;

    private DataGridView dgvDocumentRequests = null!;

    private Label lblFooter = null!;

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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        btnBack = new Button();
        picLogo = new PictureBox();
        lblTitle = new Label();
        lblSubtitle = new Label();
        pnlFormCard = new Panel();
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
        pnlSearch = new Panel();
        lblSearch = new Label();
        txtSearch = new TextBox();
        btnSearch = new Button();
        dgvDocumentRequests = new DataGridView();
        lblFooter = new Label();
        pnlHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        pnlFormCard.SuspendLayout();
        pnlSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDocumentRequests).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(128, 0, 24);
        pnlHeader.Controls.Add(btnBack);
        pnlHeader.Controls.Add(picLogo);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1180, 105);
        pnlHeader.TabIndex = 9;
        // 
        // btnBack
        // 
        btnBack.BackColor = Color.Transparent;
        btnBack.FlatAppearance.BorderSize = 0;
        btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 20, 40);
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.Font = new Font("Segoe UI", 24F);
        btnBack.ForeColor = Color.White;
        btnBack.Location = new Point(12, 17);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(55, 50);
        btnBack.TabIndex = 0;
        btnBack.Text = "←";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        // 
        // picLogo
        // 
        picLogo.Image = Properties.Resources.BatStateU_NEU_Logo_removebg_preview;
        picLogo.Location = new Point(73, 10);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(82, 82);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 1;
        picLogo.TabStop = false;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(165, 17);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(297, 41);
        lblTitle.TabIndex = 2;
        lblTitle.Text = "Document Requests";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 11F);
        lblSubtitle.ForeColor = Color.Gainsboro;
        lblSubtitle.Location = new Point(169, 62);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(246, 20);
        lblSubtitle.TabIndex = 3;
        lblSubtitle.Text = "Manage student document requests";
        // 
        // pnlFormCard
        // 
        pnlFormCard.BackColor = Color.White;
        pnlFormCard.BorderStyle = BorderStyle.FixedSingle;
        pnlFormCard.Controls.Add(lblStudent);
        pnlFormCard.Controls.Add(cmbStudent);
        pnlFormCard.Controls.Add(lblDocumentType);
        pnlFormCard.Controls.Add(cmbDocumentType);
        pnlFormCard.Controls.Add(lblPurpose);
        pnlFormCard.Controls.Add(txtPurpose);
        pnlFormCard.Controls.Add(lblRequestDate);
        pnlFormCard.Controls.Add(dtpRequestDate);
        pnlFormCard.Controls.Add(lblStatus);
        pnlFormCard.Controls.Add(cmbStatus);
        pnlFormCard.Controls.Add(lblReleaseDate);
        pnlFormCard.Controls.Add(dtpReleaseDate);
        pnlFormCard.Controls.Add(lblRemarks);
        pnlFormCard.Controls.Add(txtRemarks);
        pnlFormCard.Location = new Point(28, 125);
        pnlFormCard.Name = "pnlFormCard";
        pnlFormCard.Size = new Size(1124, 210);
        pnlFormCard.TabIndex = 8;
        // 
        // lblStudent
        // 
        lblStudent.AutoSize = true;
        lblStudent.Font = new Font("Segoe UI", 10F);
        lblStudent.Location = new Point(35, 32);
        lblStudent.Name = "lblStudent";
        lblStudent.Size = new Size(57, 19);
        lblStudent.TabIndex = 0;
        lblStudent.Text = "Student";
        // 
        // cmbStudent
        // 
        cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStudent.FormattingEnabled = true;
        cmbStudent.Location = new Point(145, 28);
        cmbStudent.Name = "cmbStudent";
        cmbStudent.Size = new Size(400, 23);
        cmbStudent.TabIndex = 1;
        // 
        // lblDocumentType
        // 
        lblDocumentType.AutoSize = true;
        lblDocumentType.Font = new Font("Segoe UI", 10F);
        lblDocumentType.Location = new Point(600, 32);
        lblDocumentType.Name = "lblDocumentType";
        lblDocumentType.Size = new Size(105, 19);
        lblDocumentType.TabIndex = 2;
        lblDocumentType.Text = "Document Type";
        // 
        // cmbDocumentType
        // 
        cmbDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDocumentType.FormattingEnabled = true;
        cmbDocumentType.Location = new Point(730, 28);
        cmbDocumentType.Name = "cmbDocumentType";
        cmbDocumentType.Size = new Size(355, 23);
        cmbDocumentType.TabIndex = 3;
        // 
        // lblPurpose
        // 
        lblPurpose.AutoSize = true;
        lblPurpose.Font = new Font("Segoe UI", 10F);
        lblPurpose.Location = new Point(35, 74);
        lblPurpose.Name = "lblPurpose";
        lblPurpose.Size = new Size(59, 19);
        lblPurpose.TabIndex = 4;
        lblPurpose.Text = "Purpose";
        // 
        // txtPurpose
        // 
        txtPurpose.Location = new Point(145, 70);
        txtPurpose.Name = "txtPurpose";
        txtPurpose.Size = new Size(400, 23);
        txtPurpose.TabIndex = 5;
        // 
        // lblRequestDate
        // 
        lblRequestDate.AutoSize = true;
        lblRequestDate.Font = new Font("Segoe UI", 10F);
        lblRequestDate.Location = new Point(600, 74);
        lblRequestDate.Name = "lblRequestDate";
        lblRequestDate.Size = new Size(91, 19);
        lblRequestDate.TabIndex = 6;
        lblRequestDate.Text = "Request Date";
        // 
        // dtpRequestDate
        // 
        dtpRequestDate.Location = new Point(730, 70);
        dtpRequestDate.Name = "dtpRequestDate";
        dtpRequestDate.Size = new Size(355, 23);
        dtpRequestDate.TabIndex = 7;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Segoe UI", 10F);
        lblStatus.Location = new Point(35, 116);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(47, 19);
        lblStatus.TabIndex = 8;
        lblStatus.Text = "Status";
        // 
        // cmbStatus
        // 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Location = new Point(145, 112);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(400, 23);
        cmbStatus.TabIndex = 9;
        // 
        // lblReleaseDate
        // 
        lblReleaseDate.AutoSize = true;
        lblReleaseDate.Font = new Font("Segoe UI", 10F);
        lblReleaseDate.Location = new Point(600, 116);
        lblReleaseDate.Name = "lblReleaseDate";
        lblReleaseDate.Size = new Size(87, 19);
        lblReleaseDate.TabIndex = 10;
        lblReleaseDate.Text = "Release Date";
        // 
        // dtpReleaseDate
        // 
        dtpReleaseDate.Checked = false;
        dtpReleaseDate.Location = new Point(730, 112);
        dtpReleaseDate.Name = "dtpReleaseDate";
        dtpReleaseDate.ShowCheckBox = true;
        dtpReleaseDate.Size = new Size(355, 23);
        dtpReleaseDate.TabIndex = 11;
        // 
        // lblRemarks
        // 
        lblRemarks.AutoSize = true;
        lblRemarks.Font = new Font("Segoe UI", 10F);
        lblRemarks.Location = new Point(35, 158);
        lblRemarks.Name = "lblRemarks";
        lblRemarks.Size = new Size(61, 19);
        lblRemarks.TabIndex = 12;
        lblRemarks.Text = "Remarks";
        // 
        // txtRemarks
        // 
        txtRemarks.Location = new Point(145, 150);
        txtRemarks.Multiline = true;
        txtRemarks.Name = "txtRemarks";
        txtRemarks.Size = new Size(400, 43);
        txtRemarks.TabIndex = 13;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(128, 0, 24);
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(34, 350);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(100, 40);
        btnAdd.TabIndex = 7;
        btnAdd.Text = "+  Add";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.WhiteSmoke;
        btnUpdate.Enabled = false;
        btnUpdate.FlatStyle = FlatStyle.Flat;
        btnUpdate.Font = new Font("Segoe UI Semibold", 10F);
        btnUpdate.Location = new Point(150, 350);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(95, 40);
        btnUpdate.TabIndex = 6;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.FromArgb(220, 53, 69);
        btnDelete.Enabled = false;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI Semibold", 10F);
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(1051, 350);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(101, 40);
        btnDelete.TabIndex = 5;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.White;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe UI Semibold", 10F);
        btnClear.ForeColor = Color.FromArgb(90, 0, 15);
        btnClear.Location = new Point(939, 350);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(96, 40);
        btnClear.TabIndex = 4;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.White;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI Semibold", 10F);
        btnRefresh.ForeColor = Color.FromArgb(90, 0, 15);
        btnRefresh.Location = new Point(264, 350);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(102, 40);
        btnRefresh.TabIndex = 3;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // pnlSearch
        // 
        pnlSearch.BackColor = Color.White;
        pnlSearch.BorderStyle = BorderStyle.FixedSingle;
        pnlSearch.Controls.Add(lblSearch);
        pnlSearch.Controls.Add(txtSearch);
        pnlSearch.Controls.Add(btnSearch);
        pnlSearch.Location = new Point(28, 410);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Size = new Size(1124, 58);
        pnlSearch.TabIndex = 2;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblSearch.Location = new Point(18, 18);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(180, 19);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Search Document Requests";
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(190, 14);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by Request ID, Student ID, Document Type or Status";
        txtSearch.Size = new Size(740, 23);
        txtSearch.TabIndex = 1;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.White;
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Location = new Point(945, 11);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(145, 32);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // dgvDocumentRequests
        // 
        dgvDocumentRequests.AllowUserToAddRows = false;
        dgvDocumentRequests.AllowUserToDeleteRows = false;
        dgvDocumentRequests.AllowUserToResizeRows = false;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 248, 248);
        dgvDocumentRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
        dgvDocumentRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvDocumentRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDocumentRequests.BackgroundColor = Color.White;
        dgvDocumentRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle5.BackColor = Color.FromArgb(128, 0, 24);
        dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        dataGridViewCellStyle5.ForeColor = Color.White;
        dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(128, 0, 24);
        dataGridViewCellStyle5.SelectionForeColor = Color.White;
        dgvDocumentRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        dgvDocumentRequests.ColumnHeadersHeight = 34;
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = Color.White;
        dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle6.ForeColor = Color.Black;
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(235, 205, 210);
        dataGridViewCellStyle6.SelectionForeColor = Color.Black;
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
        dgvDocumentRequests.DefaultCellStyle = dataGridViewCellStyle6;
        dgvDocumentRequests.EnableHeadersVisualStyles = false;
        dgvDocumentRequests.GridColor = Color.FromArgb(220, 220, 220);
        dgvDocumentRequests.Location = new Point(28, 480);
        dgvDocumentRequests.MultiSelect = false;
        dgvDocumentRequests.Name = "dgvDocumentRequests";
        dgvDocumentRequests.ReadOnly = true;
        dgvDocumentRequests.RowHeadersWidth = 35;
        dgvDocumentRequests.RowTemplate.Height = 28;
        dgvDocumentRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDocumentRequests.Size = new Size(1124, 195);
        dgvDocumentRequests.TabIndex = 1;
        dgvDocumentRequests.CellClick += dgvDocumentRequests_CellClick;
        // 
        // lblFooter
        // 
        lblFooter.Anchor = AnchorStyles.Bottom;
        lblFooter.AutoSize = true;
        lblFooter.Font = new Font("Segoe UI", 8.5F);
        lblFooter.ForeColor = Color.DimGray;
        lblFooter.Location = new Point(490, 692);
        lblFooter.Name = "lblFooter";
        lblFooter.Size = new Size(180, 15);
        lblFooter.TabIndex = 0;
        lblFooter.Text = "© 2026 Batangas State University";
        // 
        // DocumentRequestsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 245, 245);
        ClientSize = new Size(1180, 720);
        Controls.Add(lblFooter);
        Controls.Add(dgvDocumentRequests);
        Controls.Add(pnlSearch);
        Controls.Add(btnRefresh);
        Controls.Add(btnClear);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnAdd);
        Controls.Add(pnlFormCard);
        Controls.Add(pnlHeader);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(980, 620);
        Name = "DocumentRequestsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Registrar Management System - Document Requests";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        pnlFormCard.ResumeLayout(false);
        pnlFormCard.PerformLayout();
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDocumentRequests).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}