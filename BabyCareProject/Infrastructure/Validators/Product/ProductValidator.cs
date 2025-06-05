using BabyCareProject.Dtos.ProductDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Product;

public class ProductValidator:AbstractValidator<ProductManipulation>
{
    public ProductValidator()
    {
        RuleFor(p => p.Title).NotEmpty().WithMessage("Ders Ad Alanı Boş Geçilemez");
        RuleFor(p => p.Description)
            .NotEmpty().WithMessage("Açıklama Alanı Boş Geçilemez")
            .When(p=>!String.IsNullOrWhiteSpace(p.Title));
        RuleFor(p=>p.Price)
            .NotEmpty().WithMessage("Ders Ücreti Boş Geçilemez")
            .When(p=>!String.IsNullOrWhiteSpace(p.Description)); 
        RuleFor(p=>p.InstructorName)
            .NotEmpty().WithMessage("Eğitmen Adı Alanı Boş Geçilemez")
            .When(p=>!String.IsNullOrWhiteSpace(p.Price));
    }
}
