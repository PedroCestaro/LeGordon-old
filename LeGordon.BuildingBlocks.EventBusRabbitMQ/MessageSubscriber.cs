using LeGordon.BuildingBlocks.EventBus;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBusRabbitMQ
{
    public abstract class MessageSubscriber<T> where T : MessageBase , IMessageSubscriber
    {
        private readonly IQueueManager _queueManager;
        private readonly IQueueConnector _queueConnector;

        public MessageSubscriber (IQueueManager queueManager, IQueueConnector queueConnector)
        {
            _queueManager = queueManager;
            _queueConnector = queueConnector;
        }

        public async Task Consume(string queueName)
        {
            IModel _chanel = await _queueConnector.CreateChanel();
            var consumer = new EventingBasicConsumer(_chanel);

             consumer.Received += (chanel, message) =>
            {   
                var content = Encoding.UTF8.GetString(message.Body.ToArray());
                T messageType = JsonSerializer.Deserialize<T>(content);
                _chanel.BasicAck(deliveryTag: message.DeliveryTag, multiple: false);

            };
            _chanel.BasicConsume(queue: queueName, autoAck:false, consumer: consumer);
        }

        public async Task DecryptMessageContent(IModel channel, T message)
        {
            
        }
    }
}
