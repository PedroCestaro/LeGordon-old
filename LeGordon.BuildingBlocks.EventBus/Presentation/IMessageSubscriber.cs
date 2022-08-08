using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBus
{
    public interface IMessageSubscriber<in TMessage> : IMessageSubscriber
                where TMessage : MessageBase
    {
        Task Consume();
    }

    public interface IMessageSubscriber
    {

    }
}
