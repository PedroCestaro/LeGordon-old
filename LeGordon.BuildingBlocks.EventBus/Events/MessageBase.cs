using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LeGordon.BuildingBlocks.EventBus
{
    public record MessageBase
    {
        [JsonInclude]
        public Guid Id { get; private init; }

        [JsonInclude]
        public DateTime CreationDate { get; private init; }


        [JsonConstructor]
        public MessageBase(Guid id, DateTime createDate)
        {
            Id = id;
            CreationDate = createDate;
        }

        public MessageBase()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }


    }
}
