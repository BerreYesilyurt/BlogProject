using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {

        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar adını boş bırakamazsınız.");
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Başlığı boş bırakamazsınız.");
            RuleFor(x => x.AuthorImage).MinimumLength(3).WithMessage("Lütfen en az 9 karakterlik bir dosya yolu giriniz.");
            RuleFor(x => x.AuthorAbout).MaximumLength(100).WithMessage("Lütfen 50 karakteri geçmeyiniz.");
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.AboutShort).MaximumLength(100).WithMessage("Lütfen 50 karakteri geçmeyiniz.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen boş bırakmayınız.");
        }
    }
}
