using FluentValidation;
using SocialWorld.Business.DTOs.AppUserDtos;

namespace SocialWorld.Business.ValidationRules.FluentValidation
{
    class AppUserDtoValidator : AbstractValidator<AppUserDto>
    {
        public AppUserDtoValidator()
        {
            RuleFor(I => I.Email).NotEmpty().WithMessage("Kullanıcı alanı boş olamaz");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Şifre alanı boş olamaz");
            RuleFor(I => I.FirstName).NotEmpty().WithMessage("İsim alanı boş olamaz");
            RuleFor(I => I.LastName).NotEmpty().WithMessage("Soy isim alanı boş olamaz");
            RuleFor(I => I.NationalityId).NotEmpty().WithMessage("İsim alanı boş olamaz");
            RuleFor(I => I.DateOfBirth).NotEmpty().WithMessage("İsim alanı boş olamaz");

        }
    }
}