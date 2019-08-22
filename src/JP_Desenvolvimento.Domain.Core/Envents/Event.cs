using MediatR;
using System;

namespace JP_Desenvolvimento.Domain.Core.Envents
{
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}