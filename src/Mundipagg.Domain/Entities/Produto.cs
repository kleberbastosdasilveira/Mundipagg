using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mundipagg.Domain.Entities 
{
    public class Produto : Entity
    {
        public Produto(string nomeProduto, string descricaoProduto, string marcaProduto, decimal preco, string imagem, CategoriaProduto categoriadoProduto)
        {
            NomeProduto = nomeProduto;
            DescricaoProduto = descricaoProduto;
            MarcaProduto = marcaProduto;
            Preco = preco;
            Imagem = imagem;
            CategoriadoProduto = categoriadoProduto;
        }

        public string NomeProduto { get; private set; }
        public string DescricaoProduto { get; private set; }
        public string MarcaProduto { get; private set; }
        public decimal Preco { get; private set; }
        public string Imagem { get; private set; }
        public CategoriaProduto CategoriadoProduto { get; private set; }
    }
}
