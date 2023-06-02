namespace MauiToy.Views;

public partial class AdministrationPage : ContentPage
{
    public AdministrationPage()
    {
        InitializeComponent();
    }

    private async void test1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"SettingPage");
    }
    private async void test2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"SettingPage");
    }
}