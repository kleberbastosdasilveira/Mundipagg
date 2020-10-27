using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mundipagg.Domain.Entities
{
    public class Produto
    {

        [BsonId]
        public ObjectId Id { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string MarcaProduto { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
        public CategoriaProduto CategoriadoProduto { get; set; }
    }
}
