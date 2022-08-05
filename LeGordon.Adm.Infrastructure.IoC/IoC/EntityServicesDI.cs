using LeGordon.Adm.Services;

namespace LeGordon.Adm.Infrastructure.IoC
{
    public static class EntityServicesDI
    {
        public static void RegisterEntityServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
