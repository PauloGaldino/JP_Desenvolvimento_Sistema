﻿using JP_Desenvolvimento.Domain.Core.Envents;
using System;
using System.ComponentModel.DataAnnotations;

namespace JP_Desenvolvimento.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
    