using FluentValidation;
using Mundipagg.Domain.Entities;

namespace Mundipagg.Aplication.ViewModels.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(c => c.NomeProduto)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(c => c.DescricaoProduto)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(c => c.MarcaProduto)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(c => c.ImagemUrl)
                 .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(c => c.Preco)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}
