using LeGordon.Adm.Services;
using MediatR;

namespace LeGordon.Adm.Api.CQRS
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IProductService _productService;


        public Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
