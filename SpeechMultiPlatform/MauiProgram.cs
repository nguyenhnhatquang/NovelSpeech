using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace SpeechMultiPlatform;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseMauiCommunityToolkitMediaElement()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("fa-brands-400.ttf", "FAB");
				fonts.AddFont("fa-regular-400.ttf", "FAR");
				fonts.AddFont("fa-solid-900.ttf", "FAS");
			});


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
