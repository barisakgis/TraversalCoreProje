using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {

        public AboutValidator()
        {  // validation paketi ile birlikte gelen metotlar rulefor gibi


            RuleFor(x => x.Description).NotEmpty().WithMessage("açıklama kısmını boş geçemezsiniz"); 

            RuleFor(x=>x.Image1).NotEmpty().WithMessage("lütfen görsel seciniz");

            RuleFor(x => x.Description).MinimumLength(50).WithMessage("en az 50 karakterlik açıklama yapınız ");

            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("açıklamayı azalt");
        }
    }
}
