using JP_Desenvolvimento.Domain.Core.Envents;
using System;

namespace JP_Desenvolvimento.Domain.Envents
{
    public class ClienteRemovedEvent : Event
    {

        public ClienteRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
