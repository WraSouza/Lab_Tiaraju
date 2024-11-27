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
