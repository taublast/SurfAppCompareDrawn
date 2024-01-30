using DrawnUi.Maui;

namespace SurfingApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.UseDrawnUi(new()
        {
            DesktopWindow = new()
            {
                Width = 600,
                Height = 800,
                IsFixedSize = true
            }
        });

        return builder.Build();
    }
}
