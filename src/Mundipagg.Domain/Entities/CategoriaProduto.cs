using System;
using System.Collections.Generic;
using System.Text;

namespace Mundipagg.Domain.Entities
{
    public class CategoriaProduto : Entity
    {
        public CategoriaProduto(string categoria)
        {
            Categoria = categoria;
        }
        public string Categoria { get; private set; }
    }
}
