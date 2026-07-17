using RegistrarManagement.Forms;
using RegistrarManagement.Helpers;

namespace RegistrarManagement;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        FirebaseConfig.Load();
        Application.Run(new RegistrarDashboardForm());
    }
}
