using COMAVLER_ERP.Views;

namespace COMAVLER_ERP;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("login", typeof(LoginPage));
    }
}
