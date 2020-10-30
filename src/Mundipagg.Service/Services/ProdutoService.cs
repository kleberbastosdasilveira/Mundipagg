using AutoMapper;
using Mundipagg.Aplication.ViewModels;
using Mundipagg.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mundipagg.Aplication.Services
{
    public class ProdutoService : IRepositoryProdutoService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryProduto _repositoryProduto;
        public ProdutoService(IMapper mapper, IRepositoryProduto repositoryProduto)
        {
            _mapper = mapper;
            _repositoryProduto = repositoryProduto;
        }

        public async Task<ProdutoViewModel> ObterPorId(string id)
        {
            return _mapper.Map<ProdutoViewModel>(await _repositoryProduto.ObterPorId(id));
        }

        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos(int inicio, int limit)
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(await _repositoryProduto.ObterTodos(inicio, limit));
        }


    }
}
