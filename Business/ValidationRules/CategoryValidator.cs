using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>     //doğruluk geçerlilik kontrolü
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage(" Lütfen en az 3 karakterlik kategori adı girişi yapınız!");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage(" Lütfen en fazla 50 karakterlik kategori adı girişi yapınız!");

        }
    }
}
