using System.Collections.ObjectModel;

namespace MauiToy.Views;

public partial class LoginPage : ContentPage
{
    public List<Test> TestList = new List<Test>();
    public ObservableCollection<Test> TestSource = new ObservableCollection<Test>();

    public LoginPage()
    {
        InitializeComponent();

        BindingContext = this;
        for (int i = 0; i < 5; i++)
        {
            TestSource.Add(new Test
            {
                Name = $"TEST_{i}",
                Age = i,
                Address = $"ADDRESS_{i}",
                Home = $"HOME_{i}",
            });
        }
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

    public class Test
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Home { get; set; }
    }

    private void btn_AddRow_Clicked(object sender, EventArgs e)
    {
        int currentIndex = TestSource.Count;

        TestSource.Add(new Test
        {
            Name = $"TEST_{currentIndex}",
            Age = currentIndex,
            Address = $"ADDRESS_{currentIndex}",
            Home = $"HOME_{currentIndex}",
        });
    }

    private void btn_RemoveRow_Clicked(object sender, EventArgs e)
    {
        int currentIndex = TestSource.Count - 1;
        TestSource.RemoveAt(currentIndex);
    }

    private void btn_Apply_Clicked(object sender, EventArgs e)
    {
        dataGrid.ItemsSource = TestSource;
    }
}