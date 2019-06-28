using BLL;
using Microsoft.Extensions.DependencyInjection;

namespace IOC
{
    public class ServiceIOC
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IValueService, ValueService>();
        }
    }
}
