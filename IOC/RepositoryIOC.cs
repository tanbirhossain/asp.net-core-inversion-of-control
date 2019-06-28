using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace IOC
{
    public class RepositoryIOC
    {

        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IValueRepository, ValueRepository>();
        }
    }
}
