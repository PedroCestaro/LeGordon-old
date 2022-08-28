using LeGordon.Adm.Application;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LeGordon.Adm.Infrastructure.IoC
{
    public static class CqrsDI
    {
        public static void ConfigureCQRSServices(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CreateProductCommand>, CreateProductHandler>();

        }
    }
}
