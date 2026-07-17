namespace RegistrarManagement.Forms;

partial class RegistrarDashboardForm
{
    private System.ComponentModel.IContainer? components = null;

    private Label lblTitle = null!;
    private Label lblSubtitle = null!;

    private Button btnRegistration = null!;
    private Button btnAcademic = null!;
    private Button btnDocuments = null!;
    private Button btnClearances = null!;
    private Button btnExit = null!;

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
        lblTitle = new Label();
        lblSubtitle = new Label();
        btnRegistration = new Button();
        btnAcademic = new Button();
        btnDocuments = new Button();
        btnClearances = new Button();
        btnExit = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.Location = new Point(42, 30);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(341, 41);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Registrar Management";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 10F);
        lblSubtitle.Location = new Point(46, 78);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(476, 19);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Team 4 — Registration, academic records, documents, clearances and grades";
        // 
        // btnRegistration
        // 
        btnRegistration.Location = new Point(48, 135);
        btnRegistration.Name = "btnRegistration";
        btnRegistration.Size = new Size(240, 58);
        btnRegistration.TabIndex = 2;
        btnRegistration.Text = "Student Registration";
        btnRegistration.UseVisualStyleBackColor = true;
        btnRegistration.Click += btnRegistration_Click;
        // 
        // btnAcademic
        // 
        btnAcademic.Location = new Point(328, 135);
        btnAcademic.Name = "btnAcademic";
        btnAcademic.Size = new Size(240, 58);
        btnAcademic.TabIndex = 3;
        btnAcademic.Text = "Academic Records";
        btnAcademic.UseVisualStyleBackColor = true;
        btnAcademic.Click += btnAcademic_Click;
        // 
        // btnDocuments
        // 
        btnDocuments.Location = new Point(608, 135);
        btnDocuments.Name = "btnDocuments";
        btnDocuments.Size = new Size(240, 58);
        btnDocuments.TabIndex = 4;
        btnDocuments.Text = "Document Requests";
        btnDocuments.UseVisualStyleBackColor = true;
        btnDocuments.Click += btnDocuments_Click;
        // 
        // btnClearances
        // 
        btnClearances.Location = new Point(48, 225);
        btnClearances.Name = "btnClearances";
        btnClearances.Size = new Size(240, 58);
        btnClearances.TabIndex = 5;
        btnClearances.Text = "Student Clearances";
        btnClearances.UseVisualStyleBackColor = true;
        btnClearances.Click += btnClearances_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(328, 225);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(240, 58);
        btnExit.TabIndex = 7;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // RegistrarDashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(890, 360);
        Controls.Add(btnExit);
        Controls.Add(btnClearances);
        Controls.Add(btnDocuments);
        Controls.Add(btnAcademic);
        Controls.Add(btnRegistration);
        Controls.Add(lblSubtitle);
        Controls.Add(lblTitle);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "RegistrarDashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Registrar Management Dashboard";
        ResumeLayout(false);
        PerformLayout();
    }
}