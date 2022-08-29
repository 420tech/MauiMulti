namespace MauiMulti;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

#if MACCATALYST || WINDOWS
	MainPage = new AppDesktopShell();
#else
		MainPage = new AppShell();
#endif

	}
}

