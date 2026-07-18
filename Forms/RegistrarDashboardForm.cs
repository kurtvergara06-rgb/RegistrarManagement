namespace RegistrarManagement.Forms;

public partial class RegistrarDashboardForm : Form
{
    private readonly System.Windows.Forms.Timer _clockTimer = new();

    public RegistrarDashboardForm()
    {
        InitializeComponent();

        UpdateDateTime();

        _clockTimer.Interval = 1000;
        _clockTimer.Tick += ClockTimer_Tick;
        _clockTimer.Start();
    }

    private void ClockTimer_Tick(
        object? sender,
        EventArgs e)
    {
        UpdateDateTime();
    }

    private void UpdateDateTime()
    {
        lblDateTime.Text =
            DateTime.Now.ToString(
                "MMM dd, yyyy | hh:mm:ss tt"
            );
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

    private void btnRegistration_Click(
        object? sender,
        EventArgs e)
    {
        Open(new StudentRegistrationForm());
    }

    private void btnAcademic_Click(
        object? sender,
        EventArgs e)
    {
        Open(new AcademicRecordsForm());
    }

    private void btnDocuments_Click(
        object? sender,
        EventArgs e)
    {
        Open(new DocumentRequestsForm());
    }

    private void btnClearances_Click(
        object? sender,
        EventArgs e)
    {
        Open(new StudentClearancesForm());
    }

    private void btnRefresh_Click(
        object? sender,
        EventArgs e)
    {
        UpdateDateTime();
    }

    private void btnExit_Click(
        object? sender,
        EventArgs e)
    {
        Close();
    }

    private void RegistrarDashboardForm_FormClosed(
        object? sender,
        FormClosedEventArgs e)
    {
        _clockTimer.Stop();
        _clockTimer.Dispose();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        _clockTimer.Start();
    }
}