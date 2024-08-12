using Entities.Concrete;
using FluentValidation;

namespace Business.Validation.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).MinimumLength(3).WithMessage("name must be longer");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price must be great than 0").NotNull();
        }
    }
}
