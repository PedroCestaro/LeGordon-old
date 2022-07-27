using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Legordon.Adm.Api.Models;
using AutoMapper;

namespace LeGordon.Infra.IoC
{
    public static class DIApplicationContainer
    {
        public static void RegisterApplicationServices()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Mediator>().As<IMediator>();
            builder.RegisterType<Mapper>().As<IMapper>();           
        }
    }
}
