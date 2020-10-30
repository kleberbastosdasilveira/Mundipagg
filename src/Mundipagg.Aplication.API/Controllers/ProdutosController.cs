using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mundipagg.Aplication.Interfaces;
using Mundipagg.Aplication.Services;
using Mundipagg.Aplication.ViewModels;
using Mundipagg.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mundipagg.Services.API.Controllers
{
    [Route("api/produtos")]
    public class ProdutosController : BaseController
    {

        private readonly IMapper _mapper;
        private readonly IRepositoryProdutoService _repositoryProdutoService;
        private readonly IProdutoService _produtoService;
        public ProdutosController(IMapper mapper,
                                  IRepositoryProdutoService repositoryProdutoService,
                                  IProdutoService produtoService,
                                  INotificador notificador) : base(notificador)
        {
            _mapper = mapper;
            _repositoryProdutoService = repositoryProdutoService;
            _produtoService = produtoService;

        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos(int inicio = 0, int limit = 50)
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(await _repositoryProdutoService.ObterTodos(inicio, limit));
        }

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<ProdutoViewModel>> ObterPorId(string id)
        {
            var produtoViewModel = await ObterProduto(id);
            if (produtoViewModel == null) return NotFound();
            return produtoViewModel;
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoViewModel>> Adicionar(ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);
            await _produtoService.Criar(_mapper.Map<Produto>(produtoViewModel));
            return CustomResponse(produtoViewModel);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Atualizar(string id, ProdutoViewModel produtoViewModel)
        {
            if (id != produtoViewModel.Id)
            {
                NotificarErro("Os ids informados não são iguais!");
                return CustomResponse();
            }
            //var produtoAtualizar = await ObterProduto(id);
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _produtoService.Atualizar(produtoViewModel.Id, _mapper.Map<Produto>(produtoViewModel));

            return CustomResponse(produtoViewModel);
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<ActionResult<ProdutoViewModel>> Delete(string id)
        {
            var produto = await ObterProduto(id);
            if (produto == null) return NotFound();
            await _produtoService.Remover(id);

            return CustomResponse(produto);

        }

        private async Task<ProdutoViewModel> ObterProduto(string id)
        {
            return _mapper.Map<ProdutoViewModel>(await _repositoryProdutoService.ObterPorId(id));
        }
    }
}
