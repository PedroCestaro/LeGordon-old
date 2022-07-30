using AutoMapper;
using Legordon.Adm.Api.Models;

namespace Legordon.Adm.Api.Infrastructure.AutoMapper
{
    public class FromCommandToMessage : Profile
    {
        public FromCommandToMessage()
        {
            CreateMap<CreateProductCommand, CreateProductMessage>().ReverseMap();
        }
    }
}
