using Microcharts.Maui;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using VisibleOnePOS.Services.Branch;
using VisibleOnePOS.Services.Members;
using VisibleOnePOS.Services.Transaction;

namespace VisibleOnePOS
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMicrocharts()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            DependencyService.Register<IMemberService, MemberService>();
            DependencyService.Register<IBranchService, BranchService>();
            DependencyService.Register<ITransactionService, TransactionService>();
            return builder.Build();
        }
    }
}
