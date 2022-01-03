using FluentValidation;
using SocialWorld.Business.DTOs.AppUserDtos;

namespace SocialWorld.Business.ValidationRules.FluentValidation
{
    class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(I => I.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(I => I.Email).EmailAddress().WithMessage("Email düzgün yazınız");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez ");
        }
    }
}
