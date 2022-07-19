using MediatR;
using AutoMapper;
using Grpc.Core;
using LeGordon.Adm.Api.CQRS;

namespace LeGordon.Adm.Api.Services
{
    public class ProductManagementService: ProductManagement.ProductManagementBase
    {
        private readonly Mapper _mapper;
        private readonly Mediator _mediator;

        public ProductManagementService(Mapper mapper, Mediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }


        public override Task<Confirmation> CreateProduct(ProductModel request, ServerCallContext context)
        {
            var product = _mapper.Map<CreateProductCommand>(request);
            _mediator.Send(product);
            return base.CreateProduct(request, context);
        }

    }
}
