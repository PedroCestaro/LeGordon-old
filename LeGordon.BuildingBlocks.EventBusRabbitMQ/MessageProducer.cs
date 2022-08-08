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
    public class MessageProducer : IMessageProducer
    {
        const string BROKER_NAME = "legordon_Messages";


        private readonly IQueueManager _queueManager;
        private readonly IQueueConnector _queueConnector;

        public MessageProducer(IQueueManager queueManager, IQueueConnector queueConnector)
        {
            _queueManager = queueManager;   
            _queueConnector = queueConnector;
        }

        public async Task Publish(MessageBase message, string queueName)
        {
            await _queueManager.SetQueue(queueName);

            var chanel = await _queueConnector.CreateChanel();

            var exchangeName = message.GetType().Name;

            chanel.ExchangeDeclare(exchange: exchangeName, type: "direct", durable: true);

            var body = EncryptMessageBody(message);

            chanel.BasicPublish(exchange: exchangeName, routingKey: queueName, body: body);
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
