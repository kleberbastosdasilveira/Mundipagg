using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mundipagg.Aplication.ViewModels
{
    public class ProdutoViewModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string MarcaProduto { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUpload { get; set; }
        public string Imagem { get; set; }
        public CategoriaProdutoViewModel CategoriadoProduto { get; set; }
    }
}
