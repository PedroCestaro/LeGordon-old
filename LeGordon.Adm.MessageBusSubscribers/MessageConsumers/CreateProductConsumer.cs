using LeGordon.Adm.Application;
using LeGordon.BuildingBlocks.EventBus;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.Adm.UseCases.MessageConsumers
{
    public class CreateProductConsumer : BackgroundService
    {
        private readonly IMessageConsumer<CreateProductMessage> _messageConsumer;

        public CreateProductConsumer (IMessageConsumer<CreateProductMessage> messageConsumer)
        {
            _messageConsumer = messageConsumer; 
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _messageConsumer.Consume(new CreateProductMessage());
        }
    }
}
