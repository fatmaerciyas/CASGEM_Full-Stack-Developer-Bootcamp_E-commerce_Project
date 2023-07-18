using FluentValidation;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.ValidationRules.OurTeamValidator
{
    public class CreatOurTeamValidator: AbstractValidator<OurTeam>
    {
        public CreatOurTeamValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.Title).NotEmpty().MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapınız");
        }
    }
}
