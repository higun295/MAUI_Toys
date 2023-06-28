using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using MauiToy.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Maui.Animations;
using Plugin.Maui.Audio;
using System.Collections.ObjectModel;

namespace MauiToy.Views;

public partial class LoginPage : ContentPage
{
    public List<Test> TestList = new List<Test>();
    private CancellationTokenSource ctSource = new CancellationTokenSource();

    public ObservableCollection<Test> TestSource { get; set; } = new ObservableCollection<Test>();

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

    private async void btn_Login_Clicked(object sender, EventArgs e)
    {
        await PlaySound();

        var toast = Toast.Make("TEST");
        await toast.Show(ctSource.Token);
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}", new Dictionary<string, object> { { "Token", ctSource } });
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        App.ExecuteExitProcess(0);
    }

    private async Task PlaySound()
    {
        var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("DownloadOK.wav"));
        audioPlayer.Play();
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

    private async void btn_Apply_Clicked(object sender, EventArgs e)
    {
    }
}