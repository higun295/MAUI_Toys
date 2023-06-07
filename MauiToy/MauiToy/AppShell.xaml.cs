using MauiToy.Views;

namespace MauiToy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        RegisterRoute();
    }

    private void RegisterRoute()
    {
        //Routing.RegisterRoute(nameof(AdministrationPage), typeof(AdministrationPage));

        //Routing.RegisterRoute("AdministrationPage", typeof(AdministrationPage));
        //Routing.RegisterRoute("SettingPage", typeof(SettingPage));
        //Routing.RegisterRoute("PrinterSettingPage", typeof(PrinterSettingPage));
        //Routing.RegisterRoute("BufferInventoryManagementPage", typeof(BufferInventoryManagementPage));
        //Routing.RegisterRoute("ExportPackagingManagementPage", typeof(ExportPackagingManagementPage));
    }
}
