using MauiToy.Models;
using Microsoft.Extensions.Configuration;
using Plugin.Maui.Audio;
using System.Collections.ObjectModel;

namespace MauiToy.Views;

public partial class LoginPage : ContentPage
{
    public List<Test> TestList = new List<Test>();
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

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private async void btn_Login_Clicked(object sender, EventArgs e)
    {
        await PlaySound();
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
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