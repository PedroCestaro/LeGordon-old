using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBusRabbitMQ
{
    public interface IQueueManager
    {
        Task<IModel> CreateChanel();
        Task SetQueue(string queuename);
    }
}
