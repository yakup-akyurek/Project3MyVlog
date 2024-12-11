using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.CategoryValidationRules
{
    public class CreateCategoryValidator:AbstractValidator<Category>
    {
        public CreateCategoryValidator() 
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("lütfen en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("lütfen en fazla 20 karakter veri girişi yapınız");

        }

    }
}
