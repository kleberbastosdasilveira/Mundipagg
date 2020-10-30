using Mundipagg.Aplication.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mundipagg.Aplication.Services
{
    public interface IRepositoryProdutoService
    {
        Task<ProdutoViewModel> ObterPorId(string id);
        Task<IEnumerable<ProdutoViewModel>> ObterTodos(int inicio, int limit);
    }
}
