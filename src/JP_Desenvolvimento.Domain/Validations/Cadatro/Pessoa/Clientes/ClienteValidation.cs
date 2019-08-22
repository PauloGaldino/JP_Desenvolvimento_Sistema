using FluentValidation;
using JP_Desenvolvimento.Domain.Commands.Cadastro.Pessoas.Clientes;
using System;

namespace JP_Desenvolvimento.Domain.Validations.Cadastro.Pessoas.Clientes
{
    public abstract class ClienteValidation<T> : AbstractValidator<T> where T : ClienteCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Certifique-se de que o nome foi inserido")
                .Length(2, 150).WithMessage("O nome deve ter entre 2 e 150 caracteres");
        }

        protected void ValidateBirthDate()
        {
            RuleFor(c => c.DataCadastro)
                .NotEmpty()
                .Must(HaveMinimumAge)
                .WithMessage("O cliente deve ter 18 anos ou mais");
        }

        protected void ValidateEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress();
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }

        protected static bool HaveMinimumAge(DateTime dataCadastro)
        {
            return dataCadastro <= DateTime.Now.AddYears(-18);
        }
    }
}