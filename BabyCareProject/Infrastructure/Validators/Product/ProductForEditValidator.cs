using BabyCareProject.Dtos.ProductDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Product;

public class ProductForEditValidator:AbstractValidator<UpdateProductDto>
{
    public ProductForEditValidator()
    {
        Include(new ProductValidator());
        RuleFor(e => e.ImageUrl)
           .NotEmpty().WithMessage("Dersin Görseli Boş Olamaz");
    }
}
