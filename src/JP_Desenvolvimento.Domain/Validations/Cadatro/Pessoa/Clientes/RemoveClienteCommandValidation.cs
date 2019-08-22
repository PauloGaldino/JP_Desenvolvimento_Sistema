using JP_Desenvolvimento.Domain.Commands.Cadastro.Pessoas.Clientes;
using JP_Desenvolvimento.Domain.Validations.Cadastro.Pessoas.Clientes;

namespace JP_Desenvolvimento.Domain.Validations.Cadatro.Pessoa.Clientes
{
    public class RemoveClienteCommandValidation : ClienteValidation<RemoveClienteCommand>
    {
        public RemoveClienteCommandValidation()
        {
            ValidateId();
        }
    }
}
