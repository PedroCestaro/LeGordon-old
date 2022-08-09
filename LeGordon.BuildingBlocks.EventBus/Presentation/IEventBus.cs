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
            where TH : IMessageConsumer<T>;

        void Unsubscribe<T, TH>()
            where TH : IMessageConsumer<T>
            where T : MessageBase;
    }
}
