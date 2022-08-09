using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBus
{
    public interface IMessageConsumer<in TMessage> : IMessageConsumer
                where TMessage : MessageBase
    {
        Task Consume(string queueName);
    }

    public interface IMessageConsumer
    {

    }
}
