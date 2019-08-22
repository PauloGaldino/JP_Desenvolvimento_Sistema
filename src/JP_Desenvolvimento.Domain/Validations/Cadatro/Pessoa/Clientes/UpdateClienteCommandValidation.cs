using JP_Desenvolvimento.Domain.Commands.Cadastro.Pessoas.Clientes;
using JP_Desenvolvimento.Domain.Validations.Cadastro.Pessoas.Clientes;

namespace JP_Desenvolvimento.Domain.Validations.Cadatro.Pessoa.Clientes
{
    public class UpdateClienteCommandValidation : ClienteValidation<UpdateClienteCommand>
    {
        public UpdateClienteCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateBirthDate();
            ValidateEmail(); 
        }
    }
}
