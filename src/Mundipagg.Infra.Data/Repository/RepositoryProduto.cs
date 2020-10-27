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

        public Produto ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges(Produto entity)
        {
            _mundipaggDb.Produtos.InsertOne(entity);
        }
    }
}
