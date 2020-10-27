using MongoDB.Bson;
using Mundipagg.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mundipagg.Domain.Interfaces
{
    public interface IRepositoryProduto
    {
        Produto ObterPorId(ObjectId id);
        IEnumerable<Produto> ObterTodos();
        void Atualizar(Produto entity);
        void Remover(ObjectId id);
        void Create(Produto entity);
    }
}
