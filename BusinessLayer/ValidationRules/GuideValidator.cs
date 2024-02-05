using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen Rehber adını giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Rehber Açıklamsını giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Rehber Görselini giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir isim giriniz giriniz");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("Lütfen 8 karakterden daha uzun bir isim giriniz giriniz");
             
            
        }
    }
}
