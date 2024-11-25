using System.Diagnostics;

namespace Sentry.Samples.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // For this sample, we'll also register the main page for DI so we can inject a logger there.
        builder.Services.AddTransient<MainPage>();

        return builder.Build();
    }
}
