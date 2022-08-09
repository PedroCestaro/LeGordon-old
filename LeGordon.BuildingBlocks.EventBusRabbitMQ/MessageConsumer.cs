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
    public abstract class MessageConsumer<T> where T : MessageBase , IMessageConsumer<T>
    {
        private readonly IQueueManager _queueManager;
        private readonly IQueueConnector _queueConnector;
        private readonly IMessageHandler<T> _messageHandler;

        public MessageConsumer (IQueueManager queueManager, IQueueConnector queueConnector, IMessageHandler<T> messageHandler)
        {
            _queueManager = queueManager;
            _queueConnector = queueConnector;
            _messageHandler = messageHandler;
        }

        public async Task Consume(string queueName)
        {
            IModel _chanel = await _queueConnector.CreateChanel();
            var consumer = new AsyncEventingBasicConsumer(_chanel);

            await _queueManager.SetQueue(queueName);

            consumer.Received += async (chanel, message) =>
           {
               var content = Encoding.UTF8.GetString(message.Body.ToArray());
               T messageReceived = JsonSerializer.Deserialize<T>(content);

               await _messageHandler.Handle(messageReceived);

               _chanel.BasicAck(deliveryTag: message.DeliveryTag, multiple: false);
           };
            _chanel.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);
        }
    }
}
