namespace RegistrarManagement.Forms;

partial class StudentRegistrationForm
{
    private System.ComponentModel.IContainer? components = null;

    private Panel pnlHeader = null!;
    private PictureBox picLogo = null!;
    private Button btnBack = null!;
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

    private Label lblRegistrationDate = null!;
    private DateTimePicker dtpRegistrationDate = null!;

    private Label lblStatus = null!;
    private ComboBox cmbRegistrationStatus = null!;

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

    private DataGridView dgvRegistrations = null!;

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
        lblProgram = new Label();
        cmbProgram = new ComboBox();
        lblSchoolYear = new Label();
        cmbSchoolYear = new ComboBox();
        lblSemester = new Label();
        cmbSemester = new ComboBox();
        lblYearLevel = new Label();
        cmbYearLevel = new ComboBox();
        lblRegistrationDate = new Label();
        dtpRegistrationDate = new DateTimePicker();
        lblStatus = new Label();
        cmbRegistrationStatus = new ComboBox();
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
        dgvRegistrations = new DataGridView();
        lblFooter = new Label();
        pnlHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        pnlFormCard.SuspendLayout();
        pnlSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRegistrations).BeginInit();
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
        pnlHeader.TabIndex = 0;
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
        lblTitle.Size = new Size(310, 41);
        lblTitle.TabIndex = 2;
        lblTitle.Text = "Student Registration";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 11F);
        lblSubtitle.ForeColor = Color.Gainsboro;
        lblSubtitle.Location = new Point(169, 62);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(265, 20);
        lblSubtitle.TabIndex = 3;
        lblSubtitle.Text = "Manage student semester registrations";
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
        pnlFormCard.Controls.Add(lblRegistrationDate);
        pnlFormCard.Controls.Add(dtpRegistrationDate);
        pnlFormCard.Controls.Add(lblStatus);
        pnlFormCard.Controls.Add(cmbRegistrationStatus);
        pnlFormCard.Controls.Add(lblRemarks);
        pnlFormCard.Controls.Add(txtRemarks);
        pnlFormCard.Location = new Point(28, 125);
        pnlFormCard.Name = "pnlFormCard";
        pnlFormCard.Size = new Size(1124, 210);
        pnlFormCard.TabIndex = 1;
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
        cmbProgram.FormattingEnabled = true;
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
        cmbSchoolYear.FormattingEnabled = true;
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
        cmbSemester.FormattingEnabled = true;
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
        cmbYearLevel.FormattingEnabled = true;
        cmbYearLevel.Location = new Point(145, 112);
        cmbYearLevel.Name = "cmbYearLevel";
        cmbYearLevel.Size = new Size(400, 23);
        cmbYearLevel.TabIndex = 9;
        // 
        // lblRegistrationDate
        // 
        lblRegistrationDate.AutoSize = true;
        lblRegistrationDate.Font = new Font("Segoe UI", 10F);
        lblRegistrationDate.Location = new Point(600, 116);
        lblRegistrationDate.Name = "lblRegistrationDate";
        lblRegistrationDate.Size = new Size(115, 19);
        lblRegistrationDate.TabIndex = 10;
        lblRegistrationDate.Text = "Registration Date";
        // 
        // dtpRegistrationDate
        // 
        dtpRegistrationDate.Location = new Point(730, 112);
        dtpRegistrationDate.Name = "dtpRegistrationDate";
        dtpRegistrationDate.Size = new Size(355, 23);
        dtpRegistrationDate.TabIndex = 11;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Segoe UI", 10F);
        lblStatus.Location = new Point(35, 158);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(47, 19);
        lblStatus.TabIndex = 12;
        lblStatus.Text = "Status";
        // 
        // cmbRegistrationStatus
        // 
        cmbRegistrationStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRegistrationStatus.FormattingEnabled = true;
        cmbRegistrationStatus.Location = new Point(145, 154);
        cmbRegistrationStatus.Name = "cmbRegistrationStatus";
        cmbRegistrationStatus.Size = new Size(400, 23);
        cmbRegistrationStatus.TabIndex = 13;
        // 
        // lblRemarks
        // 
        lblRemarks.AutoSize = true;
        lblRemarks.Font = new Font("Segoe UI", 10F);
        lblRemarks.Location = new Point(600, 158);
        lblRemarks.Name = "lblRemarks";
        lblRemarks.Size = new Size(61, 19);
        lblRemarks.TabIndex = 14;
        lblRemarks.Text = "Remarks";
        // 
        // txtRemarks
        // 
        txtRemarks.Location = new Point(730, 150);
        txtRemarks.Multiline = true;
        txtRemarks.Name = "txtRemarks";
        txtRemarks.Size = new Size(355, 43);
        txtRemarks.TabIndex = 15;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(128, 0, 24);
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(34, 350);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(100, 40);
        btnAdd.TabIndex = 14;
        btnAdd.Text = "+  Add";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.WhiteSmoke;
        btnUpdate.Enabled = false;
        btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
        btnUpdate.FlatStyle = FlatStyle.Flat;
        btnUpdate.Font = new Font("Segoe UI Semibold", 10F);
        btnUpdate.Location = new Point(150, 350);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(96, 40);
        btnUpdate.TabIndex = 13;
        btnUpdate.Text = "✎  Update";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.FromArgb(220, 53, 69);
        btnDelete.Enabled = false;
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI Semibold", 10F);
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(1063, 350);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(89, 40);
        btnDelete.TabIndex = 12;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.White;
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(128, 0, 24);
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe UI Semibold", 10F);
        btnClear.ForeColor = Color.FromArgb(90, 0, 15);
        btnClear.Location = new Point(954, 350);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(93, 40);
        btnClear.TabIndex = 11;
        btnClear.Text = "↶  Clear";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.White;
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(128, 0, 24);
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI Semibold", 10F);
        btnRefresh.ForeColor = Color.FromArgb(90, 0, 15);
        btnRefresh.Location = new Point(263, 350);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(106, 40);
        btnRefresh.TabIndex = 10;
        btnRefresh.Text = "⟳  Refresh";
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
        pnlSearch.TabIndex = 8;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblSearch.Location = new Point(18, 18);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(137, 19);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Search Registrations";
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(170, 14);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by Registration ID, Student ID, School Year or Status";
        txtSearch.Size = new Size(760, 23);
        txtSearch.TabIndex = 1;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.White;
        btnSearch.FlatAppearance.BorderColor = Color.FromArgb(128, 0, 24);
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Location = new Point(974, 11);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(116, 32);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // dgvRegistrations
        // 
        dgvRegistrations.AllowUserToAddRows = false;
        dgvRegistrations.AllowUserToDeleteRows = false;
        dgvRegistrations.AllowUserToResizeRows = false;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 248, 248);
        dgvRegistrations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
        dgvRegistrations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvRegistrations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvRegistrations.BackgroundColor = Color.White;
        dgvRegistrations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvRegistrations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = Color.FromArgb(128, 0, 24);
        dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        dataGridViewCellStyle5.ForeColor = Color.White;
        dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(128, 0, 24);
        dataGridViewCellStyle5.SelectionForeColor = Color.White;
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
        dgvRegistrations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        dgvRegistrations.ColumnHeadersHeight = 34;
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = Color.White;
        dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle6.ForeColor = Color.Black;
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(235, 205, 210);
        dataGridViewCellStyle6.SelectionForeColor = Color.Black;
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
        dgvRegistrations.DefaultCellStyle = dataGridViewCellStyle6;
        dgvRegistrations.EnableHeadersVisualStyles = false;
        dgvRegistrations.GridColor = Color.FromArgb(220, 220, 220);
        dgvRegistrations.Location = new Point(28, 480);
        dgvRegistrations.MultiSelect = false;
        dgvRegistrations.Name = "dgvRegistrations";
        dgvRegistrations.ReadOnly = true;
        dgvRegistrations.RowHeadersWidth = 35;
        dgvRegistrations.RowTemplate.Height = 28;
        dgvRegistrations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRegistrations.Size = new Size(1124, 195);
        dgvRegistrations.TabIndex = 9;
        dgvRegistrations.CellClick += dgvRegistrations_CellClick;
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
        // StudentRegistrationForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 245, 245);
        ClientSize = new Size(1180, 720);
        Controls.Add(lblFooter);
        Controls.Add(dgvRegistrations);
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
        Name = "StudentRegistrationForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Registrar Management System - Student Registration";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        pnlFormCard.ResumeLayout(false);
        pnlFormCard.PerformLayout();
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRegistrations).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}