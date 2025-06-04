using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("lütfen ürün adını  boş geçmeyin");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapın");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapın");

            RuleFor(x => x.Price).NotEmpty().WithMessage("ürün fiyatı boş geçilemez").LessThan(0).WithMessage("ürün fiyatı negaitf olamaz").GreaterThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz") ;

            RuleFor(x=>x.Price )

        }
    }
}
