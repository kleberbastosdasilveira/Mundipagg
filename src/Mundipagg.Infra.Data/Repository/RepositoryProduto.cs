using MongoDB.Driver;
using Mundipagg.Domain.Entities;
using Mundipagg.Domain.Interfaces;
using Mundipagg.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mundipagg.Infra.Data.Repository
{
    public class RepositoryProduto : IRepositoryProduto
    {
        private readonly MundipaggDb _mundipaggDb;
        public RepositoryProduto(MundipaggDb mundipaggDb)
        {
            _mundipaggDb = mundipaggDb;
        }

        public async Task Atualizar(string id, Produto entity)
        {
            //var produto = Builders<Produto>.Filter.Eq(produto => produto.Id, entity.Id);
            await _mundipaggDb.Produtos.ReplaceOneAsync(produto => produto.Id == id, entity);
        }

        public async Task<Produto> ObterPorId(string id)
        {
            var produto = await _mundipaggDb.Produtos.FindAsync<Produto>(produto => produto.Id == id);
            return await produto.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Produto>> ObterTodos(int inicio, int limit)
        {
            return await _mundipaggDb.Produtos.Find(prod => true).Skip(inicio).Limit(limit).ToListAsync();
        }

        public async Task Remover(string id)
        {
            await _mundipaggDb.Produtos.DeleteOneAsync(produto => produto.Id == id);
        }

        public async Task Criar(Produto entity)
        {
            await _mundipaggDb.Produtos.InsertOneAsync(entity);

        }
    }
}
