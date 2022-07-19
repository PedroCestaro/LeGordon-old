using MediatR;

namespace Legordon.Adm.Api.Models
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand>
    {
        public Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
