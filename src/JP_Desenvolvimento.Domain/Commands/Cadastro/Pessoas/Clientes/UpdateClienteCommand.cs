using JP_Desenvolvimento.Domain.Validations.Cadatro.Pessoa.Clientes;
using System;

namespace JP_Desenvolvimento.Domain.Commands.Cadastro.Pessoas.Clientes
{
    public class UpdateClienteCommand : ClienteCommand
    {
        public UpdateClienteCommand(Guid id, string nome, string email, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateClienteCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
