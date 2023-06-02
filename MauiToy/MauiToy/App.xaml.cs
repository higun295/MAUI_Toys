namespace MauiToy;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    public static void ExecuteExitProcess(int exitCode = 0)
    {
        // 프로그램을 종료할 때 필요한 것들을 이곳에서 정리한다.
        Environment.Exit(exitCode);
    }
}
