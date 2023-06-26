using System.ComponentModel;
using System.Text.Json;

namespace CONFIG_TEST;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    int count = 0;
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        //await LoadMauiAsset();
        count++;
        if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "envSettings.json")))
        {
            var envSettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "envSettings.json");
            var envSettingsContent = @"{ ""KEY1"": ""value1"" }";
            File.WriteAllText(envSettingsPath, envSettingsContent);

            var existingEnvSettingsContent = File.ReadAllText(envSettingsPath);
            // Modify the content as needed
            var modifiedEnvSettingsContent = existingEnvSettingsContent.Replace("value1", "new value1");
            File.WriteAllText(envSettingsPath, modifiedEnvSettingsContent);

            Setting settings = JsonSerializer.Deserialize<Setting>(modifiedEnvSettingsContent);
            t1.Text = settings.KEY1;
        }
        else
        {
            File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "envSettings.json"));
        }


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