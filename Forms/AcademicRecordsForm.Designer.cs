namespace RegistrarManagement.Forms;

partial class AcademicRecordsForm
{
    private System.ComponentModel.IContainer? components = null;

    private Label lblTitle = null!;

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

    private Label lblSearch = null!;
    private TextBox txtSearch = null!;
    private Button btnSearch = null!;

    private DataGridView dgvAcademicRecords = null!;

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
        lblSearch = new Label();
        txtSearch = new TextBox();
        btnSearch = new Button();
        dgvAcademicRecords = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvAcademicRecords).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(25, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(223, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Academic Records";
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
        // lblProgram
        // 
        lblProgram.AutoSize = true;
        lblProgram.Location = new Point(585, 75);
        lblProgram.Name = "lblProgram";
        lblProgram.Size = new Size(53, 15);
        lblProgram.TabIndex = 3;
        lblProgram.Text = "Program";
        // 
        // cmbProgram
        // 
        cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProgram.FormattingEnabled = true;
        cmbProgram.Location = new Point(706, 70);
        cmbProgram.Name = "cmbProgram";
        cmbProgram.Size = new Size(328, 23);
        cmbProgram.TabIndex = 4;
        // 
        // lblSchoolYear
        // 
        lblSchoolYear.AutoSize = true;
        lblSchoolYear.Location = new Point(28, 117);
        lblSchoolYear.Name = "lblSchoolYear";
        lblSchoolYear.Size = new Size(68, 15);
        lblSchoolYear.TabIndex = 5;
        lblSchoolYear.Text = "School Year";
        // 
        // cmbSchoolYear
        // 
        cmbSchoolYear.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSchoolYear.FormattingEnabled = true;
        cmbSchoolYear.Location = new Point(140, 112);
        cmbSchoolYear.Name = "cmbSchoolYear";
        cmbSchoolYear.Size = new Size(390, 23);
        cmbSchoolYear.TabIndex = 6;
        // 
        // lblSemester
        // 
        lblSemester.AutoSize = true;
        lblSemester.Location = new Point(585, 117);
        lblSemester.Name = "lblSemester";
        lblSemester.Size = new Size(55, 15);
        lblSemester.TabIndex = 7;
        lblSemester.Text = "Semester";
        // 
        // cmbSemester
        // 
        cmbSemester.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSemester.FormattingEnabled = true;
        cmbSemester.Location = new Point(706, 112);
        cmbSemester.Name = "cmbSemester";
        cmbSemester.Size = new Size(328, 23);
        cmbSemester.TabIndex = 8;
        // 
        // lblYearLevel
        // 
        lblYearLevel.AutoSize = true;
        lblYearLevel.Location = new Point(28, 159);
        lblYearLevel.Name = "lblYearLevel";
        lblYearLevel.Size = new Size(59, 15);
        lblYearLevel.TabIndex = 9;
        lblYearLevel.Text = "Year Level";
        // 
        // cmbYearLevel
        // 
        cmbYearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbYearLevel.FormattingEnabled = true;
        cmbYearLevel.Location = new Point(140, 154);
        cmbYearLevel.Name = "cmbYearLevel";
        cmbYearLevel.Size = new Size(390, 23);
        cmbYearLevel.TabIndex = 10;
        // 
        // lblAcademicStatus
        // 
        lblAcademicStatus.AutoSize = true;
        lblAcademicStatus.Location = new Point(585, 159);
        lblAcademicStatus.Name = "lblAcademicStatus";
        lblAcademicStatus.Size = new Size(95, 15);
        lblAcademicStatus.TabIndex = 11;
        lblAcademicStatus.Text = "Academic Status";
        // 
        // cmbAcademicStatus
        // 
        cmbAcademicStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbAcademicStatus.FormattingEnabled = true;
        cmbAcademicStatus.Location = new Point(706, 154);
        cmbAcademicStatus.Name = "cmbAcademicStatus";
        cmbAcademicStatus.Size = new Size(328, 23);
        cmbAcademicStatus.TabIndex = 12;
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
        // dgvAcademicRecords
        // 
        dgvAcademicRecords.AllowUserToAddRows = false;
        dgvAcademicRecords.AllowUserToDeleteRows = false;
        dgvAcademicRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvAcademicRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvAcademicRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvAcademicRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvAcademicRecords.DefaultCellStyle = dataGridViewCellStyle2;
        dgvAcademicRecords.Location = new Point(28, 350);
        dgvAcademicRecords.MultiSelect = false;
        dgvAcademicRecords.Name = "dgvAcademicRecords";
        dgvAcademicRecords.ReadOnly = true;
        dgvAcademicRecords.RowHeadersWidth = 51;
        dgvAcademicRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAcademicRecords.Size = new Size(1128, 330);
        dgvAcademicRecords.TabIndex = 23;
        dgvAcademicRecords.CellClick += dgvAcademicRecords_CellClick;
        // 
        // AcademicRecordsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1180, 720);
        Controls.Add(dgvAcademicRecords);
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
        Controls.Add(cmbAcademicStatus);
        Controls.Add(lblAcademicStatus);
        Controls.Add(cmbYearLevel);
        Controls.Add(lblYearLevel);
        Controls.Add(cmbSemester);
        Controls.Add(lblSemester);
        Controls.Add(cmbSchoolYear);
        Controls.Add(lblSchoolYear);
        Controls.Add(cmbProgram);
        Controls.Add(lblProgram);
        Controls.Add(cmbStudent);
        Controls.Add(lblStudent);
        Controls.Add(lblTitle);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(980, 620);
        Name = "AcademicRecordsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Academic Records";
        ((System.ComponentModel.ISupportInitialize)dgvAcademicRecords).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}