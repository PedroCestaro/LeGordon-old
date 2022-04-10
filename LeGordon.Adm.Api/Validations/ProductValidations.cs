using FluentValidation;
using LeGordon.Adm.Api.CQRS;

namespace LeGordon.Adm.Api.Validations
{
    public class ProductValidations : AbstractValidator<CreateProductCommand>
    {
        public ProductValidations()
        {
            RuleFor(product => product.name).NotEmpty();
            RuleFor(product => product.description).NotEmpty();
            RuleFor(product => product.categoryId).NotEmpty();
        }
    }
}
