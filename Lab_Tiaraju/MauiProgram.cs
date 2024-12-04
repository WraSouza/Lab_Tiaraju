using CommunityToolkit.Maui;
using DevExpress.Maui;
using Lab_Tiaraju.Repository.Implementations;
using Lab_Tiaraju.Repository.Implementations.ReadImplementations;
using Lab_Tiaraju.Repository.Implementations.WriteImplementations;
using Lab_Tiaraju.Repository.Interfaces.ReadRepositories;
using Lab_Tiaraju.Repository.Interfaces.WriteRepositories;
using Lab_Tiaraju.Repository.ReadRepositories;
using Lab_Tiaraju.View;
using Lab_Tiaraju.ViewModel;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Toolkit.Hosting;

namespace Lab_Tiaraju
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseDevExpress()
                .UseDevExpressCharts()
                .UseMauiCommunityToolkit()
                .ConfigureSyncfusionToolkit()
                .UseSentry(options => {
                    // The DSN is the only required setting.
                    options.Dsn = "https://82f9546e266ac815af3aca84863ee3f1@o4508410133479424.ingest.us.sentry.io/4508410136494080";

                    // Use debug mode if you want to see what the SDK is doing.
                    // Debug messages are written to stdout with Console.Writeline,
                    // and are viewable in your IDE's debug console or with 'adb logcat', etc.
                    // This option is not recommended when deploying your application.
                    options.Debug = true;

                    // Set TracesSampleRate to 1.0 to capture 100% of transactions for tracing.
                    // We recommend adjusting this value in production.
                    options.TracesSampleRate = 1.0;

                    // Other Sentry options can be set here.
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Montserrat-SemiBold.ttf", "MontserratSemibold");
                    fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
                    fonts.AddFont("Montserrat-Medium.ttf", "MontserratMedium");
                    fonts.AddFont("Montserrat-Regular.ttf", "MontserratRegular");
                });

            builder.Services.AddSingleton<IReadItemsSAP, ReadItemsSAP>();
            builder.Services.AddSingleton<IReadUsuarioSAP, ReadUsuarioSAP>();
            builder.Services.AddSingleton<IWriteUsuarioSAP, WriteUsuarioSAP>();
            builder.Services.AddSingleton<IReadSalesMagento, ReadSalesMagento>();

            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<DepartmentsViewModel>();
            builder.Services.AddSingleton<ItemSAPViewModel>();
            builder.Services.AddSingleton<LojaVirtualViewModel>();
            builder.Services.AddSingleton<ComercialViewModel>();


            builder.Services.AddSingleton<LoginView>();
            builder.Services.AddSingleton<HomeView>();
            builder.Services.AddSingleton<ComercialView>();
            builder.Services.AddSingleton<ItemSAPView>();
            builder.Services.AddSingleton<LojaVirtualView>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
