namespace RegistrarManagement.Forms;

partial class AcademicRecordsForm
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

    private Label lblProgram = null!;
    private ComboBox cmbProgram = null!;

    private Label lblSchoolYear = null!;
    private ComboBox cmbSchoolYear = null!;

    private Label lblSemester = null!;
    private ComboBox cmbSemester = null!;

    private Label lblYearLevel = null!;
    private ComboBox cmbYearLevel = null!;

    private Label lblAcademicStatus = null!;
    private ComboBox cmbAcademicStatus = null!;

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

    private DataGridView dgvAcademicRecords = null!;

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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        btnBack = new Button();
        picLogo = new PictureBox();
        lblTitle = new Label();
        lblSubtitle = new Label();
        pnlFormCard = new Panel();
        lblStudent = new Label();
        cmbStudent = new ComboBox();
        lblProgram = new Label();
        cmbProgram = new ComboBox();
        lblSchoolYear = new Label();
        cmbSchoolYear = new ComboBox();
        lblSemester = new Label();
        cmbSemester = new ComboBox();
        lblYearLevel = new Label();
        cmbYearLevel = new ComboBox();
        lblAcademicStatus = new Label();
        cmbAcademicStatus = new ComboBox();
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
        dgvAcademicRecords = new DataGridView();
        lblFooter = new Label();
        pnlHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        pnlFormCard.SuspendLayout();
        pnlSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAcademicRecords).BeginInit();
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
        lblTitle.Size = new Size(273, 41);
        lblTitle.TabIndex = 2;
        lblTitle.Text = "Academic Records";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 11F);
        lblSubtitle.ForeColor = Color.Gainsboro;
        lblSubtitle.Location = new Point(169, 62);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(237, 20);
        lblSubtitle.TabIndex = 3;
        lblSubtitle.Text = "Manage student academic records";
        // 
        // pnlFormCard
        // 
        pnlFormCard.BackColor = Color.White;
        pnlFormCard.BorderStyle = BorderStyle.FixedSingle;
        pnlFormCard.Controls.Add(lblStudent);
        pnlFormCard.Controls.Add(cmbStudent);
        pnlFormCard.Controls.Add(lblProgram);
        pnlFormCard.Controls.Add(cmbProgram);
        pnlFormCard.Controls.Add(lblSchoolYear);
        pnlFormCard.Controls.Add(cmbSchoolYear);
        pnlFormCard.Controls.Add(lblSemester);
        pnlFormCard.Controls.Add(cmbSemester);
        pnlFormCard.Controls.Add(lblYearLevel);
        pnlFormCard.Controls.Add(cmbYearLevel);
        pnlFormCard.Controls.Add(lblAcademicStatus);
        pnlFormCard.Controls.Add(cmbAcademicStatus);
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
        cmbStudent.Location = new Point(145, 28);
        cmbStudent.Name = "cmbStudent";
        cmbStudent.Size = new Size(400, 23);
        cmbStudent.TabIndex = 1;
        // 
        // lblProgram
        // 
        lblProgram.AutoSize = true;
        lblProgram.Font = new Font("Segoe UI", 10F);
        lblProgram.Location = new Point(600, 32);
        lblProgram.Name = "lblProgram";
        lblProgram.Size = new Size(62, 19);
        lblProgram.TabIndex = 2;
        lblProgram.Text = "Program";
        // 
        // cmbProgram
        // 
        cmbProgram.BackColor = Color.FromArgb(235, 235, 235);
        cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProgram.Location = new Point(730, 28);
        cmbProgram.Name = "cmbProgram";
        cmbProgram.Size = new Size(355, 23);
        cmbProgram.TabIndex = 3;
        // 
        // lblSchoolYear
        // 
        lblSchoolYear.AutoSize = true;
        lblSchoolYear.Font = new Font("Segoe UI", 10F);
        lblSchoolYear.Location = new Point(35, 74);
        lblSchoolYear.Name = "lblSchoolYear";
        lblSchoolYear.Size = new Size(79, 19);
        lblSchoolYear.TabIndex = 4;
        lblSchoolYear.Text = "School Year";
        // 
        // cmbSchoolYear
        // 
        cmbSchoolYear.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSchoolYear.Location = new Point(145, 70);
        cmbSchoolYear.Name = "cmbSchoolYear";
        cmbSchoolYear.Size = new Size(400, 23);
        cmbSchoolYear.TabIndex = 5;
        // 
        // lblSemester
        // 
        lblSemester.AutoSize = true;
        lblSemester.Font = new Font("Segoe UI", 10F);
        lblSemester.Location = new Point(600, 74);
        lblSemester.Name = "lblSemester";
        lblSemester.Size = new Size(65, 19);
        lblSemester.TabIndex = 6;
        lblSemester.Text = "Semester";
        // 
        // cmbSemester
        // 
        cmbSemester.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSemester.Location = new Point(730, 70);
        cmbSemester.Name = "cmbSemester";
        cmbSemester.Size = new Size(355, 23);
        cmbSemester.TabIndex = 7;
        // 
        // lblYearLevel
        // 
        lblYearLevel.AutoSize = true;
        lblYearLevel.Font = new Font("Segoe UI", 10F);
        lblYearLevel.Location = new Point(35, 116);
        lblYearLevel.Name = "lblYearLevel";
        lblYearLevel.Size = new Size(70, 19);
        lblYearLevel.TabIndex = 8;
        lblYearLevel.Text = "Year Level";
        // 
        // cmbYearLevel
        // 
        cmbYearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbYearLevel.Location = new Point(145, 112);
        cmbYearLevel.Name = "cmbYearLevel";
        cmbYearLevel.Size = new Size(400, 23);
        cmbYearLevel.TabIndex = 9;
        // 
        // lblAcademicStatus
        // 
        lblAcademicStatus.AutoSize = true;
        lblAcademicStatus.Font = new Font("Segoe UI", 10F);
        lblAcademicStatus.Location = new Point(600, 116);
        lblAcademicStatus.Name = "lblAcademicStatus";
        lblAcademicStatus.Size = new Size(109, 19);
        lblAcademicStatus.TabIndex = 10;
        lblAcademicStatus.Text = "Academic Status";
        // 
        // cmbAcademicStatus
        // 
        cmbAcademicStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbAcademicStatus.Location = new Point(730, 112);
        cmbAcademicStatus.Name = "cmbAcademicStatus";
        cmbAcademicStatus.Size = new Size(355, 23);
        cmbAcademicStatus.TabIndex = 11;
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
        btnUpdate.Location = new Point(153, 350);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(93, 40);
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
        btnDelete.Location = new Point(1044, 350);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(108, 40);
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
        btnClear.Location = new Point(930, 350);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(99, 40);
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
        btnRefresh.Location = new Point(263, 350);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(103, 40);
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
        lblSearch.Size = new Size(170, 19);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Search Academic Records";
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(190, 14);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by Record ID, Student ID, School Year or Academic Status";
        txtSearch.Size = new Size(740, 23);
        txtSearch.TabIndex = 1;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.White;
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Location = new Point(970, 11);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(120, 32);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // dgvAcademicRecords
        // 
        dgvAcademicRecords.AllowUserToAddRows = false;
        dgvAcademicRecords.AllowUserToDeleteRows = false;
        dgvAcademicRecords.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 248, 248);
        dgvAcademicRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvAcademicRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvAcademicRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvAcademicRecords.BackgroundColor = Color.White;
        dgvAcademicRecords.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 0, 24);
        dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 0, 24);
        dgvAcademicRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvAcademicRecords.ColumnHeadersHeight = 34;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = Color.Black;
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 205, 210);
        dataGridViewCellStyle3.SelectionForeColor = Color.Black;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvAcademicRecords.DefaultCellStyle = dataGridViewCellStyle3;
        dgvAcademicRecords.EnableHeadersVisualStyles = false;
        dgvAcademicRecords.GridColor = Color.FromArgb(220, 220, 220);
        dgvAcademicRecords.Location = new Point(28, 480);
        dgvAcademicRecords.MultiSelect = false;
        dgvAcademicRecords.Name = "dgvAcademicRecords";
        dgvAcademicRecords.ReadOnly = true;
        dgvAcademicRecords.RowHeadersWidth = 35;
        dgvAcademicRecords.RowTemplate.Height = 28;
        dgvAcademicRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAcademicRecords.Size = new Size(1124, 195);
        dgvAcademicRecords.TabIndex = 1;
        dgvAcademicRecords.CellClick += dgvAcademicRecords_CellClick;
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
        // AcademicRecordsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 245, 245);
        ClientSize = new Size(1180, 720);
        Controls.Add(lblFooter);
        Controls.Add(dgvAcademicRecords);
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
        Name = "AcademicRecordsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Registrar Management System - Academic Records";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        pnlFormCard.ResumeLayout(false);
        pnlFormCard.PerformLayout();
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAcademicRecords).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}