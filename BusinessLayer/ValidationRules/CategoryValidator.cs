using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category> /*Kategorinin doğruluğunun kontrolü*/
    {
        public CategoryValidator() {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori adını boş bırakamazsınız.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş bırakamazsınız.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik bir kategori adı giriniz.");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Lütfen 50 karakteri geçmeyiniz.");
        }  
    }
}
