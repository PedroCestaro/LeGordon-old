using Legordon.Adm.Api.Models;
using MediatR;

namespace Legordon.Adm.Api.Infrastructure.IoC
{
    public static class CqrsDI
    {
        public static void ConfigureCQRSServices(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler <CreateProductCommand>, CreateProductHandler>();
            
        }
    }
}
