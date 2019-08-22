using JP_Desenvolvimento.Domain.Validations.Cadatro.Pessoa.Clientes;
using System;

namespace JP_Desenvolvimento.Domain.Commands.Cadastro.Pessoas.Clientes
{
    public class RegisterNewClienteCommand : ClienteCommand
    {
        public RegisterNewClienteCommand(string nome, string email, DateTime dataCadastro)
        {
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewClienteCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
    