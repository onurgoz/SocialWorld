using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SocialWorld.Business.DTOs.SocialResponsibilityDtos;
using SocialWorld.Entities.Concrete;

namespace SocialWorld.Business.ValidationRules.FluentValidation
{
    public class SocialResponsibilityAddDtoValidator : AbstractValidator<SocialResponsibilityAddDto>
    {
        public SocialResponsibilityAddDtoValidator()
        {
            RuleFor(I => I.Explanation).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(I => I.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(I => I.Explanation).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(I => I.Explanation).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }

    }
}
