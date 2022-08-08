using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBusRabbitMQ
{
    public class QueueManager : IQueueManager
    {

        private readonly IQueueConnector _connector;
        public List<string> Queues { get; private set; }


        public QueueManager(IQueueConnector connection)
        {
            _connector = connection;
        }
        
        public async Task SetQueue(string queuename)
        {
            if (QueueAlredyCreated(queuename))
                return;

           await CreateQueue(queuename);
        }

        private async Task<IModel> CreateQueue(string queueName)
        {
            try
            {
                Dictionary<string, object> arguments = new Dictionary<string, object>();
                arguments.Add("x-queue-type", "quorum");

                var chanel = await _connector.CreateChanel();
                chanel.QueueDeclare
                    (
                            queue: queueName,
                            durable: true,
                            exclusive: false,
                            autoDelete: false,
                            arguments: arguments
                    ) ;

                Queues.Add(queueName);

                return chanel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private bool QueueAlredyCreated(string queueName)
        {
            return Queues.Contains(queueName);
        }

       

        

    }

}
