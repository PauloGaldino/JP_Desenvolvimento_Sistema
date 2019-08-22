using JP_Desenvolvimento.Domain.Validations.Cadatro.Pessoa.Clientes;
using System;

namespace JP_Desenvolvimento.Domain.Commands.Cadastro.Pessoas.Clientes
{
    public class RemoveClienteCommand : ClienteCommand
    {
        public RemoveClienteCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new RemoveClienteCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
