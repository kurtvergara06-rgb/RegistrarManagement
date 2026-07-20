#nullable enable

namespace RegistrarManagement.Forms;

partial class StudentClearancesForm
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
    private Button btnCheckStatus = null!;

    private Label lblLibraryStatus = null!;
    private TextBox txtLibraryStatus = null!;

    private Label lblMedicalStatus = null!;
    private TextBox txtMedicalStatus = null!;

    private Label lblRegistrarStatus = null!;
    private ComboBox cmbRegistrarStatus = null!;

    private Label lblAccountingStatus = null!;
    private ComboBox cmbAccountingStatus = null!;

    private Label lblOverallStatus = null!;
    private TextBox txtOverallStatus = null!;

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
    private ComboBox cmbfilter = null!;
    private Button btnsort = null!;

    private DataGridView dgvClearances = null!;

    private Panel pnlFooter = null!;
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
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        picLogo = new PictureBox();
        btnBack = new Button();
        lblTitle = new Label();
        lblSubtitle = new Label();
        pnlFormCard = new Panel();
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
        lblOverallStatus = new Label();
        txtOverallStatus = new TextBox();
        lblRemarks = new Label();
        txtRemarks = new TextBox();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        btnRefresh = new Button();
        pnlSearch = new Panel();
        cmbfilter = new ComboBox();
        lblSearch = new Label();
        btnsort = new Button();
        txtSearch = new TextBox();
        btnSearch = new Button();
        dgvClearances = new DataGridView();
        pnlFooter = new Panel();
        lblFooter = new Label();
        pnlHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        pnlFormCard.SuspendLayout();
        pnlSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClearances).BeginInit();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(128, 0, 24);
        pnlHeader.Controls.Add(picLogo);
        pnlHeader.Controls.Add(btnBack);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1280, 100);
        pnlHeader.TabIndex = 0;
        // 
        // picLogo
        // 
        picLogo.BackColor = Color.Transparent;
        picLogo.Image = Properties.Resources.BatStateU_NEU_Logo_removebg_preview;
        picLogo.Location = new Point(64, 15);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(70, 70);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 0;
        picLogo.TabStop = false;
        // 
        // btnBack
        // 
        btnBack.BackColor = Color.FromArgb(128, 0, 24);
        btnBack.Cursor = Cursors.Hand;
        btnBack.FlatAppearance.BorderSize = 0;
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnBack.ForeColor = Color.White;
        btnBack.Location = new Point(14, 28);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(42, 42);
        btnBack.TabIndex = 0;
        btnBack.Text = "<";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(150, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(261, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Student Clearances";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 10F);
        lblSubtitle.ForeColor = Color.FromArgb(235, 220, 225);
        lblSubtitle.Location = new Point(153, 59);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(405, 19);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Review shared clearance statuses and manage registrar clearance";
        // 
        // pnlFormCard
        // 
        pnlFormCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlFormCard.BackColor = Color.White;
        pnlFormCard.BorderStyle = BorderStyle.FixedSingle;
        pnlFormCard.Controls.Add(lblStudent);
        pnlFormCard.Controls.Add(cmbStudent);
        pnlFormCard.Controls.Add(btnCheckStatus);
        pnlFormCard.Controls.Add(lblLibraryStatus);
        pnlFormCard.Controls.Add(txtLibraryStatus);
        pnlFormCard.Controls.Add(lblMedicalStatus);
        pnlFormCard.Controls.Add(txtMedicalStatus);
        pnlFormCard.Controls.Add(lblRegistrarStatus);
        pnlFormCard.Controls.Add(cmbRegistrarStatus);
        pnlFormCard.Controls.Add(lblAccountingStatus);
        pnlFormCard.Controls.Add(cmbAccountingStatus);
        pnlFormCard.Controls.Add(lblOverallStatus);
        pnlFormCard.Controls.Add(txtOverallStatus);
        pnlFormCard.Controls.Add(lblRemarks);
        pnlFormCard.Controls.Add(txtRemarks);
        pnlFormCard.Controls.Add(btnAdd);
        pnlFormCard.Controls.Add(btnUpdate);
        pnlFormCard.Controls.Add(btnDelete);
        pnlFormCard.Controls.Add(btnClear);
        pnlFormCard.Controls.Add(btnRefresh);
        pnlFormCard.Location = new Point(30, 125);
        pnlFormCard.Name = "pnlFormCard";
        pnlFormCard.Size = new Size(1220, 260);
        pnlFormCard.TabIndex = 1;
        pnlFormCard.Paint += pnlFormCard_Paint;
        // 
        // lblStudent
        // 
        lblStudent.AutoSize = true;
        lblStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblStudent.ForeColor = Color.FromArgb(60, 60, 60);
        lblStudent.Location = new Point(25, 18);
        lblStudent.Name = "lblStudent";
        lblStudent.Size = new Size(45, 15);
        lblStudent.TabIndex = 1;
        lblStudent.Text = "Student";
        // 
        // cmbStudent
        // 
        cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStudent.Font = new Font("Segoe UI", 10F);
        cmbStudent.FormattingEnabled = true;
        cmbStudent.Location = new Point(85, 14);
        cmbStudent.Name = "cmbStudent";
        cmbStudent.Size = new Size(510, 25);
        cmbStudent.TabIndex = 2;
        // 
        // btnCheckStatus
        // 
        btnCheckStatus.BackColor = Color.FromArgb(128, 0, 24);
        btnCheckStatus.Cursor = Cursors.Hand;
        btnCheckStatus.FlatStyle = FlatStyle.Flat;
        btnCheckStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnCheckStatus.ForeColor = Color.White;
        btnCheckStatus.Location = new Point(910, 12);
        btnCheckStatus.Name = "btnCheckStatus";
        btnCheckStatus.Size = new Size(275, 32);
        btnCheckStatus.TabIndex = 3;
        btnCheckStatus.Text = "Check Shared Status";
        btnCheckStatus.UseVisualStyleBackColor = false;
        btnCheckStatus.Click += btnCheckStatus_Click;
        // 
        // lblLibraryStatus
        // 
        lblLibraryStatus.AutoSize = true;
        lblLibraryStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblLibraryStatus.ForeColor = Color.FromArgb(60, 60, 60);
        lblLibraryStatus.Location = new Point(25, 55);
        lblLibraryStatus.Name = "lblLibraryStatus";
        lblLibraryStatus.Size = new Size(83, 15);
        lblLibraryStatus.TabIndex = 4;
        lblLibraryStatus.Text = "Library Status";
        // 
        // txtLibraryStatus
        // 
        txtLibraryStatus.BackColor = Color.FromArgb(245, 245, 245);
        txtLibraryStatus.Font = new Font("Segoe UI", 10F);
        txtLibraryStatus.Location = new Point(25, 77);
        txtLibraryStatus.Name = "txtLibraryStatus";
        txtLibraryStatus.ReadOnly = true;
        txtLibraryStatus.Size = new Size(275, 25);
        txtLibraryStatus.TabIndex = 5;
        // 
        // lblMedicalStatus
        // 
        lblMedicalStatus.AutoSize = true;
        lblMedicalStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblMedicalStatus.ForeColor = Color.FromArgb(60, 60, 60);
        lblMedicalStatus.Location = new Point(320, 55);
        lblMedicalStatus.Name = "lblMedicalStatus";
        lblMedicalStatus.Size = new Size(88, 15);
        lblMedicalStatus.TabIndex = 6;
        lblMedicalStatus.Text = "Medical Status";
        // 
        // txtMedicalStatus
        // 
        txtMedicalStatus.BackColor = Color.FromArgb(245, 245, 245);
        txtMedicalStatus.Font = new Font("Segoe UI", 10F);
        txtMedicalStatus.Location = new Point(320, 77);
        txtMedicalStatus.Name = "txtMedicalStatus";
        txtMedicalStatus.ReadOnly = true;
        txtMedicalStatus.Size = new Size(275, 25);
        txtMedicalStatus.TabIndex = 7;
        // 
        // lblRegistrarStatus
        // 
        lblRegistrarStatus.AutoSize = true;
        lblRegistrarStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblRegistrarStatus.ForeColor = Color.FromArgb(60, 60, 60);
        lblRegistrarStatus.Location = new Point(615, 55);
        lblRegistrarStatus.Name = "lblRegistrarStatus";
        lblRegistrarStatus.Size = new Size(96, 15);
        lblRegistrarStatus.TabIndex = 8;
        lblRegistrarStatus.Text = "Registrar Status";
        // 
        // cmbRegistrarStatus
        // 
        cmbRegistrarStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRegistrarStatus.Font = new Font("Segoe UI", 10F);
        cmbRegistrarStatus.FormattingEnabled = true;
        cmbRegistrarStatus.Location = new Point(615, 77);
        cmbRegistrarStatus.Name = "cmbRegistrarStatus";
        cmbRegistrarStatus.Size = new Size(275, 25);
        cmbRegistrarStatus.TabIndex = 9;
        // 
        // lblAccountingStatus
        // 
        lblAccountingStatus.AutoSize = true;
        lblAccountingStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblAccountingStatus.ForeColor = Color.FromArgb(60, 60, 60);
        lblAccountingStatus.Location = new Point(910, 55);
        lblAccountingStatus.Name = "lblAccountingStatus";
        lblAccountingStatus.Size = new Size(108, 15);
        lblAccountingStatus.TabIndex = 10;
        lblAccountingStatus.Text = "Accounting Status";
        // 
        // cmbAccountingStatus
        // 
        cmbAccountingStatus.BackColor = Color.FromArgb(245, 245, 245);
        cmbAccountingStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbAccountingStatus.Enabled = false;
        cmbAccountingStatus.Font = new Font("Segoe UI", 10F);
        cmbAccountingStatus.FormattingEnabled = true;
        cmbAccountingStatus.Location = new Point(910, 77);
        cmbAccountingStatus.Name = "cmbAccountingStatus";
        cmbAccountingStatus.Size = new Size(275, 25);
        cmbAccountingStatus.TabIndex = 11;
        // 
        // lblOverallStatus
        // 
        lblOverallStatus.AutoSize = true;
        lblOverallStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblOverallStatus.ForeColor = Color.FromArgb(60, 60, 60);
        lblOverallStatus.Location = new Point(25, 127);
        lblOverallStatus.Name = "lblOverallStatus";
        lblOverallStatus.Size = new Size(85, 15);
        lblOverallStatus.TabIndex = 12;
        lblOverallStatus.Text = "Overall Status";
        // 
        // txtOverallStatus
        // 
        txtOverallStatus.BackColor = Color.FromArgb(245, 245, 245);
        txtOverallStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        txtOverallStatus.Location = new Point(25, 149);
        txtOverallStatus.Name = "txtOverallStatus";
        txtOverallStatus.ReadOnly = true;
        txtOverallStatus.Size = new Size(275, 25);
        txtOverallStatus.TabIndex = 13;
        // 
        // lblRemarks
        // 
        lblRemarks.AutoSize = true;
        lblRemarks.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblRemarks.ForeColor = Color.FromArgb(60, 60, 60);
        lblRemarks.Location = new Point(320, 127);
        lblRemarks.Name = "lblRemarks";
        lblRemarks.Size = new Size(56, 15);
        lblRemarks.TabIndex = 14;
        lblRemarks.Text = "Remarks";
        // 
        // txtRemarks
        // 
        txtRemarks.Font = new Font("Segoe UI", 10F);
        txtRemarks.Location = new Point(320, 149);
        txtRemarks.Name = "txtRemarks";
        txtRemarks.Size = new Size(570, 25);
        txtRemarks.TabIndex = 15;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(128, 0, 24);
        btnAdd.Cursor = Cursors.Hand;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(25, 203);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(105, 32);
        btnAdd.TabIndex = 16;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.White;
        btnUpdate.Cursor = Cursors.Hand;
        btnUpdate.Enabled = false;
        btnUpdate.FlatStyle = FlatStyle.Flat;
        btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnUpdate.ForeColor = Color.FromArgb(128, 0, 24);
        btnUpdate.Location = new Point(140, 203);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(105, 32);
        btnUpdate.TabIndex = 17;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.White;
        btnDelete.Cursor = Cursors.Hand;
        btnDelete.Enabled = false;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDelete.ForeColor = Color.FromArgb(220, 53, 69);
        btnDelete.Location = new Point(255, 203);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(105, 32);
        btnDelete.TabIndex = 18;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.White;
        btnClear.Cursor = Cursors.Hand;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnClear.ForeColor = Color.FromArgb(128, 0, 24);
        btnClear.Location = new Point(370, 203);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(105, 32);
        btnClear.TabIndex = 19;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.White;
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRefresh.ForeColor = Color.FromArgb(128, 0, 24);
        btnRefresh.Location = new Point(485, 203);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(105, 32);
        btnRefresh.TabIndex = 20;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // pnlSearch
        // 
        pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlSearch.BackColor = Color.White;
        pnlSearch.BorderStyle = BorderStyle.FixedSingle;
        pnlSearch.Controls.Add(cmbfilter);
        pnlSearch.Controls.Add(lblSearch);
        pnlSearch.Controls.Add(btnsort);
        pnlSearch.Controls.Add(txtSearch);
        pnlSearch.Controls.Add(btnSearch);
        pnlSearch.Location = new Point(30, 400);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Size = new Size(1220, 65);
        pnlSearch.TabIndex = 2;
        // 
        // cmbfilter
        // 
        cmbfilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbfilter.Location = new Point(730, 18);
        cmbfilter.Name = "cmbfilter";
        cmbfilter.Size = new Size(133, 23);
        cmbfilter.TabIndex = 3;
        cmbfilter.SelectedIndexChanged += cmbfilter_SelectedIndexChanged;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblSearch.ForeColor = Color.FromArgb(60, 60, 60);
        lblSearch.Location = new Point(20, 22);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(45, 15);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Search";
        // 
        // btnsort
        // 
        btnsort.BackColor = Color.WhiteSmoke;
        btnsort.Enabled = false;
        btnsort.FlatStyle = FlatStyle.Flat;
        btnsort.Font = new Font("Segoe UI Semibold", 10F);
        btnsort.Location = new Point(631, 14);
        btnsort.Name = "btnsort";
        btnsort.Size = new Size(93, 32);
        btnsort.TabIndex = 2;
        btnsort.Text = "Sort";
        btnsort.UseVisualStyleBackColor = false;
        btnsort.Click += btnsort_Click;
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Segoe UI", 10F);
        txtSearch.Location = new Point(85, 18);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(420, 25);
        txtSearch.TabIndex = 1;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.FromArgb(128, 0, 24);
        btnSearch.Cursor = Cursors.Hand;
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSearch.ForeColor = Color.White;
        btnSearch.Location = new Point(520, 15);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(105, 32);
        btnSearch.TabIndex = 4;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // dgvClearances
        // 
        dgvClearances.AllowUserToAddRows = false;
        dgvClearances.AllowUserToDeleteRows = false;
        dgvClearances.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvClearances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvClearances.BackgroundColor = Color.White;
        dgvClearances.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvClearances.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 0, 24);
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dataGridViewCellStyle3.ForeColor = Color.White;
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 0, 24);
        dataGridViewCellStyle3.SelectionForeColor = Color.White;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvClearances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvClearances.ColumnHeadersHeight = 42;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = Color.White;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(50, 50, 50);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(245, 225, 230);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(80, 0, 15);
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        dgvClearances.DefaultCellStyle = dataGridViewCellStyle4;
        dgvClearances.EnableHeadersVisualStyles = false;
        dgvClearances.GridColor = Color.FromArgb(230, 230, 230);
        dgvClearances.Location = new Point(30, 480);
        dgvClearances.MultiSelect = false;
        dgvClearances.Name = "dgvClearances";
        dgvClearances.ReadOnly = true;
        dgvClearances.RowHeadersVisible = false;
        dgvClearances.RowTemplate.Height = 34;
        dgvClearances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClearances.Size = new Size(1220, 230);
        dgvClearances.TabIndex = 3;
        dgvClearances.CellClick += dgvClearances_CellClick;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = Color.FromArgb(245, 245, 245);
        pnlFooter.Controls.Add(lblFooter);
        pnlFooter.Dock = DockStyle.Bottom;
        pnlFooter.Location = new Point(0, 730);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Size = new Size(1280, 40);
        pnlFooter.TabIndex = 4;
        // 
        // lblFooter
        // 
        lblFooter.Dock = DockStyle.Fill;
        lblFooter.Font = new Font("Segoe UI", 8.5F);
        lblFooter.ForeColor = Color.Gray;
        lblFooter.Location = new Point(0, 0);
        lblFooter.Name = "lblFooter";
        lblFooter.Size = new Size(1280, 40);
        lblFooter.TabIndex = 0;
        lblFooter.Text = "(c) 2026 Batangas State University - Registrar Management System";
        lblFooter.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // StudentClearancesForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 245, 245);
        ClientSize = new Size(1280, 770);
        Controls.Add(dgvClearances);
        Controls.Add(pnlSearch);
        Controls.Add(pnlFormCard);
        Controls.Add(pnlHeader);
        Controls.Add(pnlFooter);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(1100, 700);
        Name = "StudentClearancesForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Student Clearances";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        pnlFormCard.ResumeLayout(false);
        pnlFormCard.PerformLayout();
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClearances).EndInit();
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }
}