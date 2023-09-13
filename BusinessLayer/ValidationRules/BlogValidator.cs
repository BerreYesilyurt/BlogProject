using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator() {
            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş bırakılamaz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş bırakılamaz.");
            RuleFor(x => x.BlogTitle).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik bir giriş yapınız.");
            RuleFor(x => x.BlogTitle).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla başlık girişi yapmayınız.");
        }
    }
}
