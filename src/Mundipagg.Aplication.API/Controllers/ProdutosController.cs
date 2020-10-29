using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mundipagg.Domain.Entities;
using Mundipagg.Domain.Interfaces;
using Mundipagg.Aplication.ViewModels;
using MongoDB.Bson;

namespace Mundipagg.Services.API.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IRepositoryProduto _repositoryProduto;
        private readonly IMapper _mapper;
        public ProdutosController(IRepositoryProduto repositoryProduto, IMapper mapper)
        {
            _repositoryProduto = repositoryProduto;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos(int inicio = 0, int limit = 50)
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(await _repositoryProduto.ObterTodos(inicio, limit));
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<ProdutoViewModel>> ObterPorId(string id)
        {
            var produtoViewModel = await ObterProduto(id);
            if (produtoViewModel == null) return NotFound();
            return produtoViewModel;
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoViewModel>> Adicionar(ProdutoViewModel produtoViewModel)
        {
            if(!ModelState.IsValid) return NotFound();

            var imagemNome = Guid.NewGuid() + "_" + produtoViewModel.Imagem;
            if (!UploadArquivo(produtoViewModel.ImagemUpload, imagemNome))
            {
                return produtoViewModel;
            }
            produtoViewModel.Imagem = imagemNome;
            await _repositoryProduto.Create(_mapper.Map<Produto>(produtoViewModel));

            return produtoViewModel;


        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private async Task<ProdutoViewModel> ObterProduto(string id)
        {
            return _mapper.Map<ProdutoViewModel>(await _repositoryProduto.ObterPorId(ObjectId.Parse(id)));
        }
        private bool UploadArquivo(string arquivo, string imgNome)
        {
            if (string.IsNullOrEmpty(arquivo))
            {
                return false;
            }

            var imageDataByteArray = Convert.FromBase64String(arquivo);

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imagens", imgNome);

            if (System.IO.File.Exists(filePath))
            {
               
                return false;
            }

            System.IO.File.WriteAllBytes(filePath, imageDataByteArray);

            return true;
        }
    }
}
