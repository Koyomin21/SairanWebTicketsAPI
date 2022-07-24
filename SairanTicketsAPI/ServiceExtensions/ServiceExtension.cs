using SairanTicketsAPI.Services;


namespace SairanTicketsAPI.ServiceExtensionsConfiguration
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }

}
