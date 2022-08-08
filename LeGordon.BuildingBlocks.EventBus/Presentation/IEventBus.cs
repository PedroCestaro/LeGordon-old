using LeGordon.BuildingBlocks.EventBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBus
{
    public interface IEventBus
    {
        void Subscribe<T, TH>()
            where T : MessageBase
            where TH : IMessageSubscriber<T>;

        void Unsubscribe<T, TH>()
            where TH : IMessageSubscriber<T>
            where T : MessageBase;
    }
}
