namespace RegistrarManagement.Forms;

partial class RegistrarDashboardForm
{
    private System.ComponentModel.IContainer? components = null;

    private Button btnRegistration = null!;
    private Button btnAcademic = null!;
    private Button btnDocuments = null!;
    private Button btnClearances = null!;

    private Panel panelHeader = null!;

    private PictureBox picLogo = null!;
    private PictureBox picExit = null!;

    private PictureBox picRegistration = null!;
    private PictureBox picDocuments = null!;
    private PictureBox picClearances = null!;
    private PictureBox picAcademic = null!;
    private Button btnExit = null!;

    private Label lblUniversity = null!;
    private Label lblRegistrar = null!;
    private Label lblSeparator = null!;
    private Label lblWelcome = null!;
    private Label lblDateTime = null!;

    private Label lblRegistrationDescription = null!;
    private Label lblDocumentsDescription = null!;
    private Label lblClearancesDescription = null!;
    private Label lblAcademicDescription = null!;

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
        btnRegistration = new Button();
        btnAcademic = new Button();
        btnDocuments = new Button();
        btnClearances = new Button();
        panelHeader = new Panel();
        picLogo = new PictureBox();
        lblUniversity = new Label();
        lblSeparator = new Label();
        lblRegistrar = new Label();
        lblWelcome = new Label();
        lblDateTime = new Label();
        btnExit = new Button();
        picExit = new PictureBox();
        lblRegistrationDescription = new Label();
        lblDocumentsDescription = new Label();
        lblClearancesDescription = new Label();
        lblAcademicDescription = new Label();
        picRegistration = new PictureBox();
        picDocuments = new PictureBox();
        picClearances = new PictureBox();
        picAcademic = new PictureBox();
        pictureBox2 = new PictureBox();
        panelHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picRegistration).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picDocuments).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picClearances).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picAcademic).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // btnRegistration
        // 
        btnRegistration.BackColor = Color.White;
        btnRegistration.FlatAppearance.BorderColor = Color.FromArgb(152, 26, 32);
        btnRegistration.FlatAppearance.BorderSize = 2;
        btnRegistration.FlatStyle = FlatStyle.Flat;
        btnRegistration.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
        btnRegistration.Location = new Point(18, 119);
        btnRegistration.Name = "btnRegistration";
        btnRegistration.Padding = new Padding(45, 0, 0, 35);
        btnRegistration.Size = new Size(410, 113);
        btnRegistration.TabIndex = 0;
        btnRegistration.Text = "Student Registration";
        btnRegistration.UseVisualStyleBackColor = false;
        btnRegistration.Click += btnRegistration_Click;
        // 
        // btnAcademic
        // 
        btnAcademic.BackColor = Color.White;
        btnAcademic.FlatAppearance.BorderColor = Color.FromArgb(152, 26, 32);
        btnAcademic.FlatAppearance.BorderSize = 2;
        btnAcademic.FlatStyle = FlatStyle.Flat;
        btnAcademic.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
        btnAcademic.Location = new Point(462, 247);
        btnAcademic.Name = "btnAcademic";
        btnAcademic.Padding = new Padding(45, 0, 0, 35);
        btnAcademic.Size = new Size(413, 113);
        btnAcademic.TabIndex = 3;
        btnAcademic.Text = "Academic Records";
        btnAcademic.UseVisualStyleBackColor = false;
        btnAcademic.Click += btnAcademic_Click;
        // 
        // btnDocuments
        // 
        btnDocuments.BackColor = Color.White;
        btnDocuments.FlatAppearance.BorderColor = Color.FromArgb(152, 26, 32);
        btnDocuments.FlatAppearance.BorderSize = 2;
        btnDocuments.FlatStyle = FlatStyle.Flat;
        btnDocuments.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
        btnDocuments.Location = new Point(462, 119);
        btnDocuments.Name = "btnDocuments";
        btnDocuments.Padding = new Padding(45, 0, 0, 35);
        btnDocuments.Size = new Size(413, 113);
        btnDocuments.TabIndex = 1;
        btnDocuments.Text = "Document Requests";
        btnDocuments.UseVisualStyleBackColor = false;
        btnDocuments.Click += btnDocuments_Click;
        // 
        // btnClearances
        // 
        btnClearances.BackColor = Color.White;
        btnClearances.FlatAppearance.BorderColor = Color.FromArgb(152, 26, 32);
        btnClearances.FlatAppearance.BorderSize = 2;
        btnClearances.FlatStyle = FlatStyle.Flat;
        btnClearances.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
        btnClearances.Location = new Point(18, 247);
        btnClearances.Name = "btnClearances";
        btnClearances.Padding = new Padding(45, 0, 0, 35);
        btnClearances.Size = new Size(410, 113);
        btnClearances.TabIndex = 2;
        btnClearances.Text = "Student Clearances";
        btnClearances.UseVisualStyleBackColor = false;
        btnClearances.Click += btnClearances_Click;
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.FromArgb(152, 26, 32);
        panelHeader.Controls.Add(pictureBox2);
        panelHeader.Controls.Add(picLogo);
        panelHeader.Controls.Add(lblUniversity);
        panelHeader.Controls.Add(lblSeparator);
        panelHeader.Controls.Add(lblRegistrar);
        panelHeader.Controls.Add(lblWelcome);
        panelHeader.Controls.Add(lblDateTime);
        panelHeader.Controls.Add(btnExit);
        panelHeader.Controls.Add(picExit);
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(890, 93);
        panelHeader.TabIndex = 4;
        // 
        // picLogo
        // 
        picLogo.Image = Properties.Resources.BatStateU_NEU_Logo_removebg_preview;
        picLogo.Location = new Point(20, 2);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(85, 85);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 0;
        picLogo.TabStop = false;
        // 
        // lblUniversity
        // 
        lblUniversity.AutoSize = true;
        lblUniversity.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
        lblUniversity.ForeColor = Color.White;
        lblUniversity.Location = new Point(115, 8);
        lblUniversity.Name = "lblUniversity";
        lblUniversity.Size = new Size(405, 37);
        lblUniversity.TabIndex = 1;
        lblUniversity.Text = "BATANGAS STATE UNIVERSITY";
        // 
        // lblSeparator
        // 
        lblSeparator.AutoSize = true;
        lblSeparator.Font = new Font("Segoe UI", 14F);
        lblSeparator.ForeColor = Color.White;
        lblSeparator.Location = new Point(515, 14);
        lblSeparator.Name = "lblSeparator";
        lblSeparator.Size = new Size(31, 25);
        lblSeparator.TabIndex = 2;
        lblSeparator.Text = "—";
        // 
        // lblRegistrar
        // 
        lblRegistrar.AutoSize = true;
        lblRegistrar.Font = new Font("Segoe UI", 14.25F);
        lblRegistrar.ForeColor = Color.White;
        lblRegistrar.Location = new Point(542, 14);
        lblRegistrar.Name = "lblRegistrar";
        lblRegistrar.Size = new Size(203, 25);
        lblRegistrar.TabIndex = 3;
        lblRegistrar.Text = "Registrar Management";
        // 
        // lblWelcome
        // 
        lblWelcome.AutoSize = true;
        lblWelcome.Font = new Font("Segoe UI", 14.25F);
        lblWelcome.ForeColor = Color.White;
        lblWelcome.Location = new Point(115, 50);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(90, 25);
        lblWelcome.TabIndex = 4;
        lblWelcome.Text = "Welcome";
        // 
        // lblDateTime
        // 
        lblDateTime.AutoSize = true;
        lblDateTime.Font = new Font("Segoe UI", 9F);
        lblDateTime.ForeColor = Color.White;
        lblDateTime.Location = new Point(570, 60);
        lblDateTime.Name = "lblDateTime";
        lblDateTime.Size = new Size(123, 15);
        lblDateTime.TabIndex = 5;
        lblDateTime.Text = "Jul 18, 2026 | 06:00 PM";
        // 
        // btnExit
        // 
        btnExit.BackColor = Color.White;
        btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        btnExit.Location = new Point(771, 56);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(83, 27);
        btnExit.TabIndex = 5;
        btnExit.Text = "      Exit";
        btnExit.UseVisualStyleBackColor = false;
        btnExit.Click += btnExit_Click;
        // 
        // picExit
        // 
        picExit.BackColor = Color.White;
        picExit.Image = Properties.Resources.icons8_exit_48;
        picExit.Location = new Point(802, 55);
        picExit.Name = "picExit";
        picExit.Size = new Size(22, 22);
        picExit.SizeMode = PictureBoxSizeMode.Zoom;
        picExit.TabIndex = 7;
        picExit.TabStop = false;
        // 
        // lblRegistrationDescription
        // 
        lblRegistrationDescription.AutoSize = true;
        lblRegistrationDescription.BackColor = Color.White;
        lblRegistrationDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblRegistrationDescription.Location = new Point(113, 182);
        lblRegistrationDescription.Name = "lblRegistrationDescription";
        lblRegistrationDescription.Size = new Size(251, 19);
        lblRegistrationDescription.TabIndex = 7;
        lblRegistrationDescription.Text = "Manage student semester registrations";
        // 
        // lblDocumentsDescription
        // 
        lblDocumentsDescription.AutoSize = true;
        lblDocumentsDescription.BackColor = Color.White;
        lblDocumentsDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblDocumentsDescription.Location = new Point(563, 182);
        lblDocumentsDescription.Name = "lblDocumentsDescription";
        lblDocumentsDescription.Size = new Size(233, 19);
        lblDocumentsDescription.TabIndex = 6;
        lblDocumentsDescription.Text = "Manage student document requests";
        // 
        // lblClearancesDescription
        // 
        lblClearancesDescription.AutoSize = true;
        lblClearancesDescription.BackColor = Color.White;
        lblClearancesDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblClearancesDescription.Location = new Point(114, 312);
        lblClearancesDescription.Name = "lblClearancesDescription";
        lblClearancesDescription.Size = new Size(223, 19);
        lblClearancesDescription.TabIndex = 5;
        lblClearancesDescription.Text = "Manage student clearance records";
        // 
        // lblAcademicDescription
        // 
        lblAcademicDescription.AutoSize = true;
        lblAcademicDescription.BackColor = Color.White;
        lblAcademicDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblAcademicDescription.Location = new Point(563, 312);
        lblAcademicDescription.Name = "lblAcademicDescription";
        lblAcademicDescription.Size = new Size(223, 19);
        lblAcademicDescription.TabIndex = 4;
        lblAcademicDescription.Text = "Manage student academic records";
        // 
        // picRegistration
        // 
        picRegistration.Image = Properties.Resources.ChatGPT_Image_Jul_18__2026__05_53_01_PM__1__removebg_preview;
        picRegistration.Location = new Point(30, 140);
        picRegistration.Name = "picRegistration";
        picRegistration.Size = new Size(70, 70);
        picRegistration.SizeMode = PictureBoxSizeMode.Zoom;
        picRegistration.TabIndex = 3;
        picRegistration.TabStop = false;
        // 
        // picDocuments
        // 
        picDocuments.Image = Properties.Resources.ChatGPT_Image_Jul_18__2026__05_57_36_PM_removebg_preview;
        picDocuments.Location = new Point(478, 135);
        picDocuments.Name = "picDocuments";
        picDocuments.Size = new Size(79, 85);
        picDocuments.SizeMode = PictureBoxSizeMode.Zoom;
        picDocuments.TabIndex = 2;
        picDocuments.TabStop = false;
        // 
        // picClearances
        // 
        picClearances.Image = Properties.Resources.ChatGPT_Image_Jul_18__2026__06_01_23_PM_removebg_preview;
        picClearances.Location = new Point(32, 265);
        picClearances.Name = "picClearances";
        picClearances.Size = new Size(70, 78);
        picClearances.SizeMode = PictureBoxSizeMode.Zoom;
        picClearances.TabIndex = 1;
        picClearances.TabStop = false;
        // 
        // picAcademic
        // 
        picAcademic.Image = Properties.Resources.ChatGPT_Image_Jul_18__2026__06_03_14_PM_removebg_preview;
        picAcademic.Location = new Point(480, 264);
        picAcademic.Name = "picAcademic";
        picAcademic.Size = new Size(70, 78);
        picAcademic.SizeMode = PictureBoxSizeMode.Zoom;
        picAcademic.TabIndex = 0;
        picAcademic.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.White;
        pictureBox2.Image = Properties.Resources.icons8_exit_48;
        pictureBox2.Location = new Point(775, 57);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(23, 23);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 9;
        pictureBox2.TabStop = false;
        // 
        // RegistrarDashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(890, 378);
        Controls.Add(picAcademic);
        Controls.Add(picClearances);
        Controls.Add(picDocuments);
        Controls.Add(picRegistration);
        Controls.Add(lblAcademicDescription);
        Controls.Add(lblClearancesDescription);
        Controls.Add(lblDocumentsDescription);
        Controls.Add(lblRegistrationDescription);
        Controls.Add(panelHeader);
        Controls.Add(btnClearances);
        Controls.Add(btnDocuments);
        Controls.Add(btnAcademic);
        Controls.Add(btnRegistration);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "RegistrarDashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Registrar Management Dashboard";
        FormClosed += RegistrarDashboardForm_FormClosed;
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
        ((System.ComponentModel.ISupportInitialize)picRegistration).EndInit();
        ((System.ComponentModel.ISupportInitialize)picDocuments).EndInit();
        ((System.ComponentModel.ISupportInitialize)picClearances).EndInit();
        ((System.ComponentModel.ISupportInitialize)picAcademic).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    private PictureBox pictureBox2;
}