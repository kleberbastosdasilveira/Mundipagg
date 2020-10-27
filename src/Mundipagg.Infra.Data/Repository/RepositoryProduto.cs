using MongoDB.Bson;
using MongoDB.Driver;
using Mundipagg.Domain.Entities;
using Mundipagg.Domain.Interfaces;
using Mundipagg.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
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

        public void Atualizar(Produto entity)
        {
            var produto = Builders<Produto>.Filter.Eq(produto => produto.Id, entity.Id);
            _mundipaggDb.Produtos.ReplaceOne(produto,entity);
        }

        public Produto ObterPorId(ObjectId id)
        {
            return _mundipaggDb.Produtos.Find<Produto>(produto => produto.Id == id).FirstOrDefault();
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _mundipaggDb.Produtos.Find(prod => true).ToList();
        }

        public void Remover(ObjectId id)
        {
            _mundipaggDb.Produtos.DeleteOne(produto => produto.Id == id);
        }

        public void Create(Produto entity)
        {
            _mundipaggDb.Produtos.InsertOne(entity);
        }
    }
}
