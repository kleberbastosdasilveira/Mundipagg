using Mundipagg.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mundipagg.Domain.Interfaces
{
    public interface IRepositoryProduto
    {
        Produto ObterPorId(Guid id);
        IEnumerable<Produto> ObterTodos();
        void Atualizar(Produto entity);
        void Remover(Guid id);
        void SaveChanges(Produto entity);
    }
}
