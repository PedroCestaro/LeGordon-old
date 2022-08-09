using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBus
{
    public interface IMessageHandler<in TMessage> : IMessageHandler
                where TMessage : MessageBase
    {
        Task Handle(TMessage message);
    }

    public interface IMessageHandler
    {

    }
}
