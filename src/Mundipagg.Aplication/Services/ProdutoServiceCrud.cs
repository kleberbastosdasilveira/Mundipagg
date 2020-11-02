using Mundipagg.Aplication.Interfaces;
using Mundipagg.Aplication.ViewModels.Validations;
using Mundipagg.Domain.Entities;
using Mundipagg.Domain.Interfaces;
using System.Threading.Tasks;

namespace Mundipagg.Aplication.Services
{
    public class ProdutoServiceCrud : BaseService, IProdutoService
    {
        private readonly IRepositoryProduto _repositoryProduto;
        public ProdutoServiceCrud(IRepositoryProduto repositoryProduto,
                                  INotificador notificador) : base(notificador)
        {
            _repositoryProduto = repositoryProduto;
        }
        public async Task<bool> Atualizar(string id, Produto entity)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), entity)) return false;

            await _repositoryProduto.Atualizar(id, entity);
            return true;
        }

        public async Task<bool> Criar(Produto entity)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), entity)
                || !ExecutarValidacao(new CategoriaProdutoValidation(), entity.CategoriadoProduto)) return false;

            await _repositoryProduto.Criar(entity);
            return true;
        }

        public async Task<bool> Remover(string id)
        {
            await _repositoryProduto.Remover(id);
            return true;
        }
    }
}
