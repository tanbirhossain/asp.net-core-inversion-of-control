using Microsoft.Extensions.DependencyInjection;

namespace IOC
{
    public static class IOCContainer
    {
        public static void BuildContainer(this IServiceCollection services)
        {
            ServiceIOC.Configure(services);
            RepositoryIOC.Configure(services);
        }
    }
}
