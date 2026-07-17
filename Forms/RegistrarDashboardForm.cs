namespace RegistrarManagement.Forms;

public partial class RegistrarDashboardForm : Form
{
    public RegistrarDashboardForm()
    {
        InitializeComponent();
    }

    private void Open(Form form)
    {
        try
        {
            using (form)
            {
                form.ShowDialog(this);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.ToString(),
                "Form Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void btnRegistration_Click(object? sender, EventArgs e)
    {
        Open(new StudentRegistrationForm());
    }

    private void btnAcademic_Click(object? sender, EventArgs e)
    {
        Open(new AcademicRecordsForm());
    }

    private void btnDocuments_Click(object? sender, EventArgs e)
    {
        Open(new DocumentRequestsForm());
    }

    private void btnClearances_Click(object? sender, EventArgs e)
    {
        Open(new StudentClearancesForm());
    }

    private void btnExit_Click(object? sender, EventArgs e)
    {
        Close();
    }
}