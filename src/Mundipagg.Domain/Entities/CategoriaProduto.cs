namespace Mundipagg.Domain.Entities
{
    public class CategoriaProduto
    {
        public CategoriaProduto(string categoria)
        {
            Categoria = categoria;
        }
        public string Categoria { get; private set; }
    }
}
