using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mundipagg.Domain.Entities
{
    public class Produto
    {
        public Produto(string id, string nomeProduto, string descricaoProduto, string marcaProduto, decimal preco, string imagemUrl, CategoriaProduto categoriadoProduto)
        {
            Id = id;
            NomeProduto = nomeProduto;
            DescricaoProduto = descricaoProduto;
            MarcaProduto = marcaProduto;
            Preco = preco;
            ImagemUrl = imagemUrl;
            CategoriadoProduto = categoriadoProduto;
        }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public string NomeProduto { get; private set; }
        public string DescricaoProduto { get; private set; }
        public string MarcaProduto { get; private set; }
        public decimal Preco { get; private set; }
        public string ImagemUrl { get; private set; }
        public CategoriaProduto CategoriadoProduto { get; private set; }
    }
}
