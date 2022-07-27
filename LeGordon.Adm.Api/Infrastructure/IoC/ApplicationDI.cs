using MediatR;
using AutoMapper;

namespace Legordon.Adm.Api.Infrastructure.IoC
{
    public static class ApplicationDI
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            var assembly = typeof(Program).Assembly;
            services.AddAutoMapper(assembly);
            services.AddMediatR(assembly);
        }
    }
}
