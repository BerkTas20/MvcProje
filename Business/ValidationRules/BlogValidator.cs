using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
       public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını boş geçemezsiniz!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini boş geçemezsiniz!");
            RuleFor(x => x.BlogTitle).MinimumLength(3).WithMessage("En az 3 karakterlik blog başlığı girişi yapmalısınız!");
            RuleFor(x => x.BlogTitle).MaximumLength(50).WithMessage("En fazla 50  karakterlik blog başlığı girişi  yapmalısınız!");

        }
    }
}
