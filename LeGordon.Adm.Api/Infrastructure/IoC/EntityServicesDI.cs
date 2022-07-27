using LeGordon.Adm.Services;

namespace Legordon.Adm.Api.Infrastructure.IoC
{
    public static class EntityServicesDI
    {
        public static void RegisterEntityServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
