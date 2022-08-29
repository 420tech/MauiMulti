


namespace MauiMulti;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Register View Models
		builder.Services.AddSingleton<StartViewModel>();
		builder.Services.AddTransient<DetailViewModel>();

		// Register Views
		builder.Services.AddSingleton<StartPage>();
		builder.Services.AddTransient<DetailPage>();

		return builder.Build();
	}
}

