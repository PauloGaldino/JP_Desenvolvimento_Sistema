using JP_Desenvolvimento.Domain.Interfaces.Repositories;
using JP_Desevolvimento.Domain.Models;

namespace JP_Desenvolvimento.Domain.Interfaces.RepositoriesCadastro.Pessoas.Clientes
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente GetByEmail(string email);
    }
}