namespace COMAVLER_ERP.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void btn_Login_Clicked(object sender, EventArgs e)
    {
        await SecureStorage.SetAsync("hasAuth", "true");
        await Shell.Current.GoToAsync("///home");
    }
}