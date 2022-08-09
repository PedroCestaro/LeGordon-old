using MediatR;
using AutoMapper;
using LeGordon.BuildingBlocks.EventBus;
using System.Text.Json;

namespace LeGordon.Adm.Application
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IMapper _mapper;
        private readonly IMessageProducer _messageProducer;

        public CreateProductHandler(IMapper mapper, IMessageProducer messageProducer)
        {
            _mapper = mapper;
            _messageProducer = messageProducer;
        }
        public Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var CreateProductMessage = _mapper.Map<CreateProductMessage>(request);

            _messageProducer.Publish(CreateProductMessage);

            return Task.FromResult(Unit.Value);
        }
    }
}
