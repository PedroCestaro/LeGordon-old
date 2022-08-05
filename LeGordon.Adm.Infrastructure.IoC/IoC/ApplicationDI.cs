using MediatR;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;


namespace LeGordon.Adm.Infrastructure.IoC
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
