using JP_Desenvolvimento.Domain.Core.Envents;
using System;

namespace JP_Desenvolvimento.Domain.Envents
{
    public class ClienteRegisteredEvent : Event
    {
        public ClienteRegisteredEvent(Guid id, string nome, string email, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
        }

        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
