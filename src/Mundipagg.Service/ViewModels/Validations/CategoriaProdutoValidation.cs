using FluentValidation;
using Mundipagg.Domain.Entities;

namespace Mundipagg.Aplication.ViewModels.Validations
{
    public class CategoriaProdutoValidation : AbstractValidator<CategoriaProduto>
    {
        public CategoriaProdutoValidation()
        {
            RuleFor(c => c.Categoria)
            .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
