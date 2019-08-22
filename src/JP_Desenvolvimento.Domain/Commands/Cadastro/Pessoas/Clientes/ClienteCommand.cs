using JP_Desenvolvimento.Domain.Core.Commands;
using System;

namespace JP_Desenvolvimento.Domain.Commands.Cadastro.Pessoas.Clientes
{
    public abstract class ClienteCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public DateTime DataCadastro { get; protected set; }
    }
}
