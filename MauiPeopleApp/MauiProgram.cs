using Microsoft.Extensions.Logging;
using MauiPeopleApp.Services;
using MauiPeopleApp.ViewModels;
using MauiPeopleApp.Views;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace MauiPeopleApp;

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
        
        // services
        builder.Services.AddSingleton<PersonService>();
        builder.Services.AddSingleton<HttpClient>();
        
        // ViewModels
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<PersonListViewModel>();
        builder.Services.AddTransient<PersonDetailViewModel>();
        
        // pages
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<PersonListPage>();
        builder.Services.AddTransient<PersonDetailPage>();
        

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}