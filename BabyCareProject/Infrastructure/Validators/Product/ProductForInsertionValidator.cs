using BabyCareProject.Dtos.ProductDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Product;

public class ProductForInsertionValidator:AbstractValidator<CreateProdutDto>
{
    public ProductForInsertionValidator()
    {
        Include(new ProductValidator());
        RuleFor(p => p.ImageFile)
            .NotNull().WithMessage("Ders Resmi Boş Geçilemez")
            .Must(file => file?.Length > 0).WithMessage("Lütfen bir resim dosyası seçiniz");
    }
}
