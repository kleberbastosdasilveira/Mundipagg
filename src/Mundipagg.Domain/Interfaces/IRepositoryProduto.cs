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
        Task<Produto> ObterPorId(ObjectId id);
        Task<IEnumerable<Produto>> ObterTodos(int inicio,int limit);
        Task Atualizar(Produto entity);
        Task Remover(ObjectId id);
        Task Create(Produto entity);
    }
}
