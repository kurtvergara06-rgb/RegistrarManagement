namespace RegistrarManagement.Forms;

partial class StudentClearancesForm
{
    private System.ComponentModel.IContainer? components = null;

    private Label lblTitle = null!;

    private Label lblStudent = null!;
    private ComboBox cmbStudent = null!;
    private Button btnCheckStatus = null!;

    private Label lblLibraryStatus = null!;
    private TextBox txtLibraryStatus = null!;

    private Label lblMedicalStatus = null!;
    private TextBox txtMedicalStatus = null!;

    private Label lblRegistrarStatus = null!;
    private ComboBox cmbRegistrarStatus = null!;

    private Label lblAccountingStatus = null!;
    private ComboBox cmbAccountingStatus = null!;

    private Label lblGuidanceStatus = null!;
    private ComboBox cmbGuidanceStatus = null!;

    private Label lblOverallStatus = null!;
    private TextBox txtOverallStatus = null!;

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

    private DataGridView dgvClearances = null!;

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
        btnCheckStatus = new Button();
        lblLibraryStatus = new Label();
        txtLibraryStatus = new TextBox();
        lblMedicalStatus = new Label();
        txtMedicalStatus = new TextBox();
        lblRegistrarStatus = new Label();
        cmbRegistrarStatus = new ComboBox();
        lblAccountingStatus = new Label();
        cmbAccountingStatus = new ComboBox();
        lblGuidanceStatus = new Label();
        cmbGuidanceStatus = new ComboBox();
        lblOverallStatus = new Label();
        txtOverallStatus = new TextBox();
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
        dgvClearances = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvClearances).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(25, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(231, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Student Clearances";
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
        // btnCheckStatus
        // 
        btnCheckStatus.Location = new Point(571, 66);
        btnCheckStatus.Name = "btnCheckStatus";
        btnCheckStatus.Size = new Size(150, 32);
        btnCheckStatus.TabIndex = 3;
        btnCheckStatus.Text = "Check Shared Status";
        btnCheckStatus.UseVisualStyleBackColor = true;
        btnCheckStatus.Click += btnCheckStatus_Click;
        // 
        // lblLibraryStatus
        // 
        lblLibraryStatus.AutoSize = true;
        lblLibraryStatus.Location = new Point(28, 117);
        lblLibraryStatus.Name = "lblLibraryStatus";
        lblLibraryStatus.Size = new Size(78, 15);
        lblLibraryStatus.TabIndex = 4;
        lblLibraryStatus.Text = "Library Status";
        // 
        // txtLibraryStatus
        // 
        txtLibraryStatus.Location = new Point(140, 112);
        txtLibraryStatus.Name = "txtLibraryStatus";
        txtLibraryStatus.ReadOnly = true;
        txtLibraryStatus.Size = new Size(390, 23);
        txtLibraryStatus.TabIndex = 5;
        // 
        // lblMedicalStatus
        // 
        lblMedicalStatus.AutoSize = true;
        lblMedicalStatus.Location = new Point(585, 117);
        lblMedicalStatus.Name = "lblMedicalStatus";
        lblMedicalStatus.Size = new Size(84, 15);
        lblMedicalStatus.TabIndex = 6;
        lblMedicalStatus.Text = "Medical Status";
        // 
        // txtMedicalStatus
        // 
        txtMedicalStatus.Location = new Point(695, 112);
        txtMedicalStatus.Name = "txtMedicalStatus";
        txtMedicalStatus.ReadOnly = true;
        txtMedicalStatus.Size = new Size(372, 23);
        txtMedicalStatus.TabIndex = 7;
        // 
        // lblRegistrarStatus
        // 
        lblRegistrarStatus.AutoSize = true;
        lblRegistrarStatus.Location = new Point(28, 159);
        lblRegistrarStatus.Name = "lblRegistrarStatus";
        lblRegistrarStatus.Size = new Size(88, 15);
        lblRegistrarStatus.TabIndex = 8;
        lblRegistrarStatus.Text = "Registrar Status";
        // 
        // cmbRegistrarStatus
        // 
        cmbRegistrarStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRegistrarStatus.FormattingEnabled = true;
        cmbRegistrarStatus.Location = new Point(140, 154);
        cmbRegistrarStatus.Name = "cmbRegistrarStatus";
        cmbRegistrarStatus.Size = new Size(390, 23);
        cmbRegistrarStatus.TabIndex = 9;
        // 
        // lblAccountingStatus
        // 
        lblAccountingStatus.AutoSize = true;
        lblAccountingStatus.Location = new Point(585, 159);
        lblAccountingStatus.Name = "lblAccountingStatus";
        lblAccountingStatus.Size = new Size(104, 15);
        lblAccountingStatus.TabIndex = 10;
        lblAccountingStatus.Text = "Accounting Status";
        // 
        // cmbAccountingStatus
        // 
        cmbAccountingStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbAccountingStatus.FormattingEnabled = true;
        cmbAccountingStatus.Location = new Point(695, 154);
        cmbAccountingStatus.Name = "cmbAccountingStatus";
        cmbAccountingStatus.Size = new Size(372, 23);
        cmbAccountingStatus.TabIndex = 11;
        // 
        // lblGuidanceStatus
        // 
        lblGuidanceStatus.AutoSize = true;
        lblGuidanceStatus.Location = new Point(28, 201);
        lblGuidanceStatus.Name = "lblGuidanceStatus";
        lblGuidanceStatus.Size = new Size(92, 15);
        lblGuidanceStatus.TabIndex = 12;
        lblGuidanceStatus.Text = "Guidance Status";
        // 
        // cmbGuidanceStatus
        // 
        cmbGuidanceStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbGuidanceStatus.FormattingEnabled = true;
        cmbGuidanceStatus.Location = new Point(140, 196);
        cmbGuidanceStatus.Name = "cmbGuidanceStatus";
        cmbGuidanceStatus.Size = new Size(390, 23);
        cmbGuidanceStatus.TabIndex = 13;
        // 
        // lblOverallStatus
        // 
        lblOverallStatus.AutoSize = true;
        lblOverallStatus.Location = new Point(585, 201);
        lblOverallStatus.Name = "lblOverallStatus";
        lblOverallStatus.Size = new Size(79, 15);
        lblOverallStatus.TabIndex = 14;
        lblOverallStatus.Text = "Overall Status";
        // 
        // txtOverallStatus
        // 
        txtOverallStatus.Location = new Point(695, 196);
        txtOverallStatus.Name = "txtOverallStatus";
        txtOverallStatus.ReadOnly = true;
        txtOverallStatus.Size = new Size(372, 23);
        txtOverallStatus.TabIndex = 15;
        // 
        // lblRemarks
        // 
        lblRemarks.AutoSize = true;
        lblRemarks.Location = new Point(28, 243);
        lblRemarks.Name = "lblRemarks";
        lblRemarks.Size = new Size(52, 15);
        lblRemarks.TabIndex = 16;
        lblRemarks.Text = "Remarks";
        // 
        // txtRemarks
        // 
        txtRemarks.Location = new Point(140, 238);
        txtRemarks.Name = "txtRemarks";
        txtRemarks.Size = new Size(390, 23);
        txtRemarks.TabIndex = 17;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(28, 282);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(95, 34);
        btnAdd.TabIndex = 18;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Enabled = false;
        btnUpdate.Location = new Point(133, 282);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(95, 34);
        btnUpdate.TabIndex = 19;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Enabled = false;
        btnDelete.Location = new Point(238, 282);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(95, 34);
        btnDelete.TabIndex = 20;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(343, 282);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(95, 34);
        btnClear.TabIndex = 21;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(448, 282);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(95, 34);
        btnRefresh.TabIndex = 22;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(28, 347);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(42, 15);
        lblSearch.TabIndex = 23;
        lblSearch.Text = "Search";
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(90, 342);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(360, 23);
        txtSearch.TabIndex = 24;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(460, 338);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(95, 32);
        btnSearch.TabIndex = 25;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // dgvClearances
        // 
        dgvClearances.AllowUserToAddRows = false;
        dgvClearances.AllowUserToDeleteRows = false;
        dgvClearances.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvClearances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvClearances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvClearances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvClearances.DefaultCellStyle = dataGridViewCellStyle2;
        dgvClearances.Location = new Point(28, 386);
        dgvClearances.MultiSelect = false;
        dgvClearances.Name = "dgvClearances";
        dgvClearances.ReadOnly = true;
        dgvClearances.RowHeadersWidth = 51;
        dgvClearances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClearances.Size = new Size(1097, 294);
        dgvClearances.TabIndex = 26;
        dgvClearances.CellClick += dgvClearances_CellClick;
        // 
        // StudentClearancesForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1180, 720);
        Controls.Add(dgvClearances);
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
        Controls.Add(txtOverallStatus);
        Controls.Add(lblOverallStatus);
        Controls.Add(cmbGuidanceStatus);
        Controls.Add(lblGuidanceStatus);
        Controls.Add(cmbAccountingStatus);
        Controls.Add(lblAccountingStatus);
        Controls.Add(cmbRegistrarStatus);
        Controls.Add(lblRegistrarStatus);
        Controls.Add(txtMedicalStatus);
        Controls.Add(lblMedicalStatus);
        Controls.Add(txtLibraryStatus);
        Controls.Add(lblLibraryStatus);
        Controls.Add(btnCheckStatus);
        Controls.Add(cmbStudent);
        Controls.Add(lblStudent);
        Controls.Add(lblTitle);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(980, 620);
        Name = "StudentClearancesForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Student Clearances";
        ((System.ComponentModel.ISupportInitialize)dgvClearances).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}