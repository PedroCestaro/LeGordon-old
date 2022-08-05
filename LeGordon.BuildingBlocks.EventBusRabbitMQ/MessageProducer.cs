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

        public MessageProducer(IQueueManager queueManager)
        {
            _queueManager = queueManager;   
        }

        public async Task Publish(MessageBase message, string queueName)
        {
            await _queueManager.SetQueue(queueName);

            var chanel = await _queueManager.CreateChanel();

            var body = EncryptMessageBody(message);

            chanel.BasicPublish(exchange: BROKER_NAME, routingKey: queueName, body: body);
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
