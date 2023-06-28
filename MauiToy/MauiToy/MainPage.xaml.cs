using CommunityToolkit.Maui.Alerts;
using MauiToy.Views;

namespace MauiToy;

[QueryProperty(nameof(TokenSource), "Token")]
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public CancellationTokenSource TokenSource
    {
        set { SetValue(value); }
    }

    public void SetValue(CancellationTokenSource source)
    {
        source.Cancel();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PrinterSettingPage));
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(ExportPackagingManagementPage)}");
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(BufferInventoryManagementPage)}");
    }
}