using LeGordon.BuildingBlocks.EventBus;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBusRabbitMQ
{
    public class RabbitMQProducer : IMessageProducer
    {
        private readonly string _hostname;
        private readonly string _password;
        private readonly string _username;
        private readonly bool _lifeTime;
        private IConnection _connection;

        public RabbitMQProducer(string hostname, string password, string username, bool lifeTime)
        {
            _hostname = hostname;       
            _password = password;
            _username = username;
            _lifeTime = lifeTime;
        }


        public Task Publish(MessageBase message, string queueName)
        {
            var chanel = SetChanel(queueName);
           

            return Task.CompletedTask;
        }

        private byte[] EncryptMessageBody(MessageBase messageBase)
        {
            //receber o json apenas, para depois converter

            return Byte.(messageBase);
        }

        private IModel SetChanel(string queueName)
        {
            CreateConnection();
            var chanel = _connection.CreateModel();
            chanel.QueueDeclare(
                                        queue: queueName,
                                        durable: _lifeTime,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null
                                        );

            return chanel;
        }

        private void CreateConnection()
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = _hostname,
                Password = _password,
                UserName = _username
            };

            _connection = connectionFactory.CreateConnection();
        }

        
    }
}
