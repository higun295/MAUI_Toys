namespace MauiToy.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void btn_Setting_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}/{nameof(AdministrationPage)}");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private async void btn_Login_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        App.ExecuteExitProcess(0);
    }
}