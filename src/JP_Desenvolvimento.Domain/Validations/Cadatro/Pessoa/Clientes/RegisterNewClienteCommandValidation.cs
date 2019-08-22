using JP_Desenvolvimento.Domain.Commands.Cadastro.Pessoas.Clientes;
using JP_Desenvolvimento.Domain.Validations.Cadastro.Pessoas.Clientes;

namespace JP_Desenvolvimento.Domain.Validations.Cadatro.Pessoa.Clientes
{
    public class RegisterNewClienteCommandValidation : ClienteValidation<RegisterNewClienteCommand>
    {
        public RegisterNewClienteCommandValidation()
        {
            ValidateName();
            ValidateEmail();
            ValidateBirthDate();
        }
    }
}
