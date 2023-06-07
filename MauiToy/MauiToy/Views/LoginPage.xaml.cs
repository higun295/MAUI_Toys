namespace MauiToy.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void btn_Setting_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//LoginPage/AdministrationPage");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        App.ExecuteExitProcess(0);
    }
}