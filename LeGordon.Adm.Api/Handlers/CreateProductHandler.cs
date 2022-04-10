using MediatR;

namespace LeGordon.Adm.Api.CQRS
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand>
    {
        public Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
