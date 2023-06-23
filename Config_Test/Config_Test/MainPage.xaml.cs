namespace CONFIG_TEST;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        var test2 = FileSystem.Current.AppDataDirectory;
        var test4 = FileSystem.Current.CacheDirectory;

        var test3 = Directory.GetFiles(test2);
        var test5 = Directory.GetFiles(test4);

        //var test = FileSystem.OpenAppPackageFileAsync("Assets/envSettings.json");

        //var context = Android.App.Application.Context;
        //using (var assetManager = context.Assets)
        //{
        //    using (var stream = assetManager.Open("envSettings.json"))
        //    {

        //    }
        //}

        //var test2 = Path.Combine(new[] { test, "Resources", "Assets" });

        //if (Directory.Exists(test2))
        //{

        //}
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

