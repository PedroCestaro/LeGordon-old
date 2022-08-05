using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBus
{
    public interface IMessageProducer
    {
        Task Publish(MessageBase message, string queueName);
    }
}
