using Microsoft.Extensions.Logging;
using AppAmbit;

namespace AppAmbit.Victor;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>();

#if ANDROID
		// TODO: Replace with your actual AppAmbit Android app key from dashboard
		string appAmbitAppKey = "df32dacf-66a2-42ba-8224-180a61b26242";
		builder.UseAppAmbit(appAmbitAppKey);
#elif IOS
		// TODO: Replace with your actual AppAmbit iOS app key from dashboard
		string appAmbitAppKey = "fb22ad48-1e25-437f-a815-15640f6adfb7";
		builder.UseAppAmbit(appAmbitAppKey);
#else
		// For other platforms, do not use AppAmbit
#endif

		builder
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
