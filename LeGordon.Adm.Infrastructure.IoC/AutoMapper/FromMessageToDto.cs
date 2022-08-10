using AutoMapper;
using LeGordon.Adm.Application;
using LeGordon.Adm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.Infrastructure.IoC.AutoMapper
{
    public class FromMessageToDto : Profile
    {
        public FromMessageToDto()
        {
            CreateMap<CreateProductMessage, ProductDto>().ReverseMap();
        }
    }
}
