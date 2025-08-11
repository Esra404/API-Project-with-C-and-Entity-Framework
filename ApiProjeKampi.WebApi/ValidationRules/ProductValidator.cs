using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin");
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("Ürün adı en fazla 50 karakter olmalıdır");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatını boş geçmeyin").LessThan(1000).WithMessage("Ürün fiyatı 0'dan küçük olamaz").GreaterThan(0).WithMessage("Ürün fiyatı 1000'den büyük olmalıdır");
            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklamasını boş geçmeyin");
        }
    }
}
