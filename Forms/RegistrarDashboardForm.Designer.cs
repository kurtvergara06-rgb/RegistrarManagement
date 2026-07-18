namespace RegistrarManagement.Forms;

partial class RegistrarDashboardForm
{
    private System.ComponentModel.IContainer? components = null;

    private Button btnRegistration = null!;
    private Button btnAcademic = null!;
    private Button btnDocuments = null!;
    private Button btnClearances = null!;

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
        panel1 = new Panel();
        pictureBox3 = new PictureBox();
        pictureBox2 = new PictureBox();
        button2 = new Button();
        pictureBox1 = new PictureBox();
        button1 = new Button();
        maskedTextBox4 = new MaskedTextBox();
        maskedTextBox3 = new MaskedTextBox();
        maskedTextBox2 = new MaskedTextBox();
        maskedTextBox1 = new MaskedTextBox();
        maskedTextBox5 = new MaskedTextBox();
        maskedTextBox6 = new MaskedTextBox();
        maskedTextBox7 = new MaskedTextBox();
        maskedTextBox8 = new MaskedTextBox();
        pictureBox4 = new PictureBox();
        pictureBox5 = new PictureBox();
        pictureBox6 = new PictureBox();
        pictureBox7 = new PictureBox();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
        SuspendLayout();
        // 
        // btnRegistration
        // 
        btnRegistration.BackColor = SystemColors.Window;
        btnRegistration.FlatAppearance.BorderColor = Color.FromArgb(152, 26, 32);
        btnRegistration.FlatAppearance.BorderSize = 2;
        btnRegistration.FlatStyle = FlatStyle.Flat;
        btnRegistration.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
        btnRegistration.Location = new Point(18, 119);
        btnRegistration.Margin = new Padding(3, 3, 3, 0);
        btnRegistration.Name = "btnRegistration";
        btnRegistration.Padding = new Padding(25, 0, 0, 0);
        btnRegistration.Size = new Size(410, 113);
        btnRegistration.TabIndex = 2;
        btnRegistration.Text = "Student Registartion\r\n\r\n";
        btnRegistration.UseVisualStyleBackColor = false;
        btnRegistration.Click += btnRegistration_Click;
        // 
        // btnAcademic
        // 
        btnAcademic.FlatAppearance.BorderColor = Color.FromArgb(152, 26, 32);
        btnAcademic.FlatAppearance.BorderSize = 2;
        btnAcademic.FlatStyle = FlatStyle.Flat;
        btnAcademic.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
        btnAcademic.Location = new Point(462, 247);
        btnAcademic.Name = "btnAcademic";
        btnAcademic.Padding = new Padding(7, 0, 0, 35);
        btnAcademic.Size = new Size(413, 113);
        btnAcademic.TabIndex = 3;
        btnAcademic.Text = "Academic Records";
        btnAcademic.UseVisualStyleBackColor = true;
        btnAcademic.Click += btnAcademic_Click;
        // 
        // btnDocuments
        // 
        btnDocuments.FlatAppearance.BorderColor = Color.FromArgb(152, 26, 32);
        btnDocuments.FlatAppearance.BorderSize = 2;
        btnDocuments.FlatStyle = FlatStyle.Flat;
        btnDocuments.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
        btnDocuments.Location = new Point(462, 119);
        btnDocuments.Name = "btnDocuments";
        btnDocuments.Padding = new Padding(25, 0, 0, 35);
        btnDocuments.Size = new Size(413, 113);
        btnDocuments.TabIndex = 2;
        btnDocuments.Text = "Document Requests";
        btnDocuments.UseVisualStyleBackColor = false;
        btnDocuments.Click += btnDocuments_Click;
        // 
        // btnClearances
        // 
        btnClearances.FlatAppearance.BorderColor = Color.FromArgb(152, 26, 32);
        btnClearances.FlatAppearance.BorderSize = 2;
        btnClearances.FlatStyle = FlatStyle.Flat;
        btnClearances.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
        btnClearances.Location = new Point(18, 247);
        btnClearances.Name = "btnClearances";
        btnClearances.Padding = new Padding(10, 0, 0, 35);
        btnClearances.Size = new Size(410, 113);
        btnClearances.TabIndex = 5;
        btnClearances.Text = "Student Clearances";
        btnClearances.UseVisualStyleBackColor = true;
        btnClearances.Click += btnClearances_Click;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(152, 26, 32);
        panel1.Controls.Add(pictureBox3);
        panel1.Controls.Add(pictureBox2);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(pictureBox1);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(maskedTextBox4);
        panel1.Controls.Add(maskedTextBox3);
        panel1.Controls.Add(maskedTextBox2);
        panel1.Controls.Add(maskedTextBox1);
        panel1.Location = new Point(1, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(890, 93);
        panel1.TabIndex = 8;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = Properties.Resources.BatStateU_NEU_Logo_removebg_preview;
        pictureBox3.Location = new Point(20, 2);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(85, 85);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 9;
        pictureBox3.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.White;
        pictureBox2.Image = Properties.Resources.icons8_reload_50;
        pictureBox2.Location = new Point(760, 55);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(22, 22);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 10;
        pictureBox2.TabStop = false;
        pictureBox2.Click += pictureBox2_Click;
        // 
        // button2
        // 
        button2.Location = new Point(755, 52);
        button2.Name = "button2";
        button2.Size = new Size(33, 27);
        button2.TabIndex = 12;
        button2.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.White;
        pictureBox1.Image = Properties.Resources.icons8_exit_48;
        pictureBox1.Location = new Point(802, 55);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(22, 22);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 9;
        pictureBox1.TabStop = false;
        // 
        // button1
        // 
        button1.BackColor = Color.White;
        button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(794, 52);
        button1.Name = "button1";
        button1.Size = new Size(83, 27);
        button1.TabIndex = 11;
        button1.Text = "      Exit";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // maskedTextBox4
        // 
        maskedTextBox4.BackColor = Color.FromArgb(152, 26, 32);
        maskedTextBox4.BorderStyle = BorderStyle.None;
        maskedTextBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        maskedTextBox4.ForeColor = SystemColors.Window;
        maskedTextBox4.Location = new Point(115, 50);
        maskedTextBox4.Name = "maskedTextBox4";
        maskedTextBox4.Size = new Size(243, 26);
        maskedTextBox4.TabIndex = 10;
        maskedTextBox4.Text = "Welcome";
        // 
        // maskedTextBox3
        // 
        maskedTextBox3.BackColor = Color.FromArgb(152, 26, 32);
        maskedTextBox3.BorderStyle = BorderStyle.None;
        maskedTextBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        maskedTextBox3.ForeColor = SystemColors.Window;
        maskedTextBox3.Location = new Point(515, 8);
        maskedTextBox3.Name = "maskedTextBox3";
        maskedTextBox3.Size = new Size(20, 26);
        maskedTextBox3.TabIndex = 10;
        maskedTextBox3.Text = "___";
        maskedTextBox3.MaskInputRejected += maskedTextBox3_MaskInputRejected;
        // 
        // maskedTextBox2
        // 
        maskedTextBox2.BackColor = Color.FromArgb(152, 26, 32);
        maskedTextBox2.BorderStyle = BorderStyle.None;
        maskedTextBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        maskedTextBox2.ForeColor = SystemColors.Window;
        maskedTextBox2.Location = new Point(550, 16);
        maskedTextBox2.Name = "maskedTextBox2";
        maskedTextBox2.Size = new Size(243, 26);
        maskedTextBox2.TabIndex = 9;
        maskedTextBox2.Text = "Registrar Management ";
        maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
        // 
        // maskedTextBox1
        // 
        maskedTextBox1.BackColor = Color.FromArgb(152, 26, 32);
        maskedTextBox1.BorderStyle = BorderStyle.None;
        maskedTextBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        maskedTextBox1.ForeColor = SystemColors.Window;
        maskedTextBox1.Location = new Point(115, 8);
        maskedTextBox1.Name = "maskedTextBox1";
        maskedTextBox1.Size = new Size(397, 36);
        maskedTextBox1.TabIndex = 0;
        maskedTextBox1.Text = "BATANGAS STATE UNIVERSITY";
        maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
        // 
        // maskedTextBox5
        // 
        maskedTextBox5.BackColor = Color.White;
        maskedTextBox5.BorderStyle = BorderStyle.None;
        maskedTextBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        maskedTextBox5.ForeColor = SystemColors.InfoText;
        maskedTextBox5.Location = new Point(113, 182);
        maskedTextBox5.Name = "maskedTextBox5";
        maskedTextBox5.Size = new Size(290, 22);
        maskedTextBox5.TabIndex = 10;
        maskedTextBox5.Text = "Manage student semester registrations";
        // 
        // maskedTextBox6
        // 
        maskedTextBox6.BackColor = Color.White;
        maskedTextBox6.BorderStyle = BorderStyle.None;
        maskedTextBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        maskedTextBox6.ForeColor = SystemColors.InfoText;
        maskedTextBox6.Location = new Point(563, 182);
        maskedTextBox6.Name = "maskedTextBox6";
        maskedTextBox6.Size = new Size(290, 22);
        maskedTextBox6.TabIndex = 11;
        maskedTextBox6.Text = "Manage Student document requests";
        maskedTextBox6.MaskInputRejected += maskedTextBox6_MaskInputRejected;
        // 
        // maskedTextBox7
        // 
        maskedTextBox7.BackColor = Color.White;
        maskedTextBox7.BorderStyle = BorderStyle.None;
        maskedTextBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        maskedTextBox7.ForeColor = SystemColors.InfoText;
        maskedTextBox7.Location = new Point(563, 312);
        maskedTextBox7.Name = "maskedTextBox7";
        maskedTextBox7.Size = new Size(290, 22);
        maskedTextBox7.TabIndex = 12;
        maskedTextBox7.Text = "Manage student academic records";
        maskedTextBox7.MaskInputRejected += maskedTextBox7_MaskInputRejected;
        // 
        // maskedTextBox8
        // 
        maskedTextBox8.BackColor = Color.White;
        maskedTextBox8.BorderStyle = BorderStyle.None;
        maskedTextBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        maskedTextBox8.ForeColor = SystemColors.InfoText;
        maskedTextBox8.Location = new Point(114, 312);
        maskedTextBox8.Name = "maskedTextBox8";
        maskedTextBox8.Size = new Size(290, 22);
        maskedTextBox8.TabIndex = 13;
        maskedTextBox8.Text = "Manage student clearance records";
        maskedTextBox8.MaskInputRejected += maskedTextBox8_MaskInputRejected;
        // 
        // pictureBox4
        // 
        pictureBox4.Image = Properties.Resources.ChatGPT_Image_Jul_18__2026__05_53_01_PM__1__removebg_preview;
        pictureBox4.Location = new Point(30, 140);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(70, 70);
        pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox4.TabIndex = 14;
        pictureBox4.TabStop = false;
        // 
        // pictureBox5
        // 
        pictureBox5.Image = Properties.Resources.ChatGPT_Image_Jul_18__2026__05_57_36_PM_removebg_preview;
        pictureBox5.Location = new Point(478, 135);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new Size(79, 85);
        pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox5.TabIndex = 15;
        pictureBox5.TabStop = false;
        // 
        // pictureBox6
        // 
        pictureBox6.Image = Properties.Resources.ChatGPT_Image_Jul_18__2026__06_01_23_PM_removebg_preview;
        pictureBox6.Location = new Point(32, 265);
        pictureBox6.Name = "pictureBox6";
        pictureBox6.Size = new Size(70, 78);
        pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox6.TabIndex = 16;
        pictureBox6.TabStop = false;
        // 
        // pictureBox7
        // 
        pictureBox7.Image = Properties.Resources.ChatGPT_Image_Jul_18__2026__06_03_14_PM_removebg_preview;
        pictureBox7.Location = new Point(480, 264);
        pictureBox7.Name = "pictureBox7";
        pictureBox7.Size = new Size(70, 78);
        pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox7.TabIndex = 17;
        pictureBox7.TabStop = false;
        // 
        // RegistrarDashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(890, 378);
        Controls.Add(pictureBox7);
        Controls.Add(pictureBox6);
        Controls.Add(pictureBox5);
        Controls.Add(pictureBox4);
        Controls.Add(maskedTextBox8);
        Controls.Add(maskedTextBox7);
        Controls.Add(maskedTextBox6);
        Controls.Add(maskedTextBox5);
        Controls.Add(panel1);
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
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    private Panel panel1;
    private MaskedTextBox maskedTextBox1;
    private MaskedTextBox maskedTextBox2;
    private MaskedTextBox maskedTextBox3;
    private MaskedTextBox maskedTextBox4;
    private Button button1;
    private PictureBox pictureBox1;
    private Button button2;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private MaskedTextBox maskedTextBox5;
    private MaskedTextBox maskedTextBox6;
    private MaskedTextBox maskedTextBox7;
    private MaskedTextBox maskedTextBox8;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private PictureBox pictureBox6;
    private PictureBox pictureBox7;
}