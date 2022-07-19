using FluentValidation;
using LeGordon.Adm.Api.CQRS;

namespace LeGordon.Adm.Api.Validations
{
    public class ProductValidations : AbstractValidator<CreateProductCommand>
    {
        public ProductValidations()
        {
            RuleFor(product => product.name).NotEmpty().NotNull();
            RuleFor(product => product.description).NotEmpty().NotNull();
            RuleFor(product => product.categoryId).NotEmpty().NotNull();
        }
    }
}
