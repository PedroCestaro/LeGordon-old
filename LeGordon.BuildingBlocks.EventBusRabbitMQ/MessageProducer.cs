using LeGordon.BuildingBlocks.EventBus;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBusRabbitMQ
{
    public class MessageProducer<T> : IMessageProducer
                    where T : MessageBase
    {

        private readonly IQueueManager _queueManager;
        private readonly IQueueConnector _queueConnector;

        public MessageProducer(IQueueManager queueManager, IQueueConnector queueConnector)
        {
            _queueManager = queueManager;   
            _queueConnector = queueConnector;
        }

        public async Task Publish(MessageBase message)
        {
            string routingKey = message.GetType().Name;

            var chanel = await _queueConnector.CreateChanel();

            string exchangeName = _queueManager.GetExchangeName();

            chanel.ExchangeDeclare(exchange: exchangeName, type: "direct", durable: true);

            var body = EncryptMessageBody(message);

            chanel.BasicPublish(exchange: exchangeName, routingKey: routingKey, body: body);
        }

        private byte[] EncryptMessageBody(MessageBase message)
        {
            return JsonSerializer.SerializeToUtf8Bytes(
                 value: message, 
                 inputType: message.GetType(),
                 options : new JsonSerializerOptions() { WriteIndented = true}
                 );
        }




    }
}
