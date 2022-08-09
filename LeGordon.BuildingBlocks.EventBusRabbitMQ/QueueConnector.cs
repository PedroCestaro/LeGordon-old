using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBusRabbitMQ
{
    public class QueueConnector : IQueueConnector
    {
        private readonly string _hostname;
        private readonly string _password;
        private readonly string _username;

        private IConnection _connection;

        public QueueConnector(string hostname, string password, string username)
        {
            _hostname = hostname;
            _password = password;
            _username = username;    
            _connection = CreateConnection();
        }


        public IConnection CreateConnection()
        {
            try
            {
                var connectionFactory = new ConnectionFactory()
                {
                    HostName = _hostname,
                    Password = _password,
                    UserName = _username
                };

                return connectionFactory.CreateConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to connect: " + ex.Message, ex.InnerException);
            }
        }
        private bool IsConnected()
        {
            return _connection != null && _connection.IsOpen;
        }

        public Task<IModel> CreateChanel()
        {
            if (!IsConnected())
                _connection = CreateConnection();

            return Task.FromResult(_connection.CreateModel());
        }

        private void Dispose()
        {
            _connection.Dispose();
        }

    }
}
