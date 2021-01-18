using AppService.appinterface;
using AppService.concrete;
using Microsoft.Extensions.DependencyInjection;

namespace winestore
{
    public class DependencyInjection
    {
        public static void DoDependencyInjection(IServiceCollection services)
        {
            services.AddTransient<IWineAppService, WineAppService>();
        }
    }
}