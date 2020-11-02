using Mundipagg.Domain.Entities;
using System.Threading.Tasks;

namespace Mundipagg.Aplication.Interfaces
{
    public interface IProdutoService
    {
        Task<bool> Atualizar(string id, Produto entity);
        Task<bool> Remover(string id);
        Task<bool> Criar(Produto entity);
    }
}
