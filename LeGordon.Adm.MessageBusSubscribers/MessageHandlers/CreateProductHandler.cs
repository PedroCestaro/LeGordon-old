using AutoMapper;
using LeGordon.Adm.Application;
using LeGordon.Adm.Services;
using LeGordon.BuildingBlocks.EventBus;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.UseCases
{
    internal class CreateProductHandler : IMessageHandler<CreateProductMessage>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public CreateProductHandler (IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task Handle(CreateProductMessage message)
        {
            var productDto = _mapper.Map<ProductDto>(message);

            await _productService.CreateProduct(productDto);
        }
    }
}
