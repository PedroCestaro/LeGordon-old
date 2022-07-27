using LeGordon.Adm.Services;
using MediatR;
using AutoMapper;

namespace Legordon.Adm.Api.Models
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public CreateProductHandler (IProductService ProductService, IMapper mapper)
        {
            _productService = ProductService;
            _mapper = mapper;
        }
        public Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var newProductModel = _mapper.Map<ProductDto>(request);

            return Task.FromResult(Unit.Value);
        }
    }
}
