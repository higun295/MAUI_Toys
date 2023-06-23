using System.Text.Json;

namespace CONFIG_TEST;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await LoadMauiAsset();
    }

    private async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("envSettings.json");
        using var reader = new StreamReader(stream);

        var test = await reader.ReadToEndAsync();
        testLabel.Text = test;

        Setting settings = JsonSerializer.Deserialize<Setting>(test);

        t1.Text = settings.KEY1;
        t2.Text = settings.KEY2;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}


public class Setting
{
    public string KEY1 { get; set; }
    public string KEY2 { get; set; }
}