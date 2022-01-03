using FluentValidation;
using SocialWorld.Business.DTOs.AppUserDtos;

namespace SocialWorld.Business.ValidationRules.FluentValidation
{
    class AppUserAddDtoValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddDtoValidator()
        {
            RuleFor(I => I.Email).NotEmpty().WithMessage("Kullanıcı alanı boş olamaz");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Şifre alanı boş olamaz");
            RuleFor(I => I.Name).NotEmpty().WithMessage("İsim alanı boş olamaz");

        }
    }
}
