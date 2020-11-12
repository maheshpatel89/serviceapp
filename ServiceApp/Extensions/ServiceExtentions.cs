using Microsoft.Extensions.DependencyInjection;
using ServiceApp.Repositories;
using ServiceApp.Services;


namespace ServiceApp.Extensions
{
    public static class ServiceExtentions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
