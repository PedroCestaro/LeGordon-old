using LeGordon.Adm.Services;
using Microsoft.Extensions.DependencyInjection;

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
