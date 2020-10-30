using Mundipagg.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mundipagg.Domain.Interfaces
{
    public interface IRepositoryProduto
    {
        Task<Produto> ObterPorId(string id);
        Task<IEnumerable<Produto>> ObterTodos(int inicio, int limit);
        Task Atualizar(string id, Produto entity);
        Task Remover(string id);
        Task Criar(Produto entity);
    }
}
