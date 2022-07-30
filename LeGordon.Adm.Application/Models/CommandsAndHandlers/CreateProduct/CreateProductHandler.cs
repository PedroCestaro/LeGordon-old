using LeGordon.Adm.Services;
using MediatR;
using AutoMapper;
using LeGordon.BuildingBlocks.EventBus;
using System.Text.Json;

namespace LeGordon.Adm.Application
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IMessageProducer _messageProducer;

        public CreateProductHandler(IProductService ProductService, IMapper mapper, IMessageProducer messageProducer)
        {
            _productService = ProductService;
            _mapper = mapper;
            _messageProducer = messageProducer;
        }
        public Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var messageModel = _mapper.Map<CreateProductMessage>(request);
            var createProductMessageBody = JsonSerializer.Serialize(messageModel);

            _messageProducer.Publish(createProductMessageBody, "");

            return Task.FromResult(Unit.Value);
        }
    }
}
