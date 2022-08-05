using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBusRabbitMQ
{
    public class QueueConnector
    {
        private readonly string _hostname;
        private readonly string _password;
        private readonly string _username;

        public QueueConnector(string hostname, string password, string username)
        {
            _hostname = hostname;
            _password = password;
            _username = username;          
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
    }
}
