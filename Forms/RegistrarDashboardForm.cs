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

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }
}