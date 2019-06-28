using Microsoft.Extensions.DependencyInjection;

namespace IOC
{
    public class IOCContainer
    {
        public static void Build(IServiceCollection services)
        {
            ServiceIOC.Configure(services);
            RepositoryIOC.Configure(services);
        }
    }
}
