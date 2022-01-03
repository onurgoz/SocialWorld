using FluentValidation;
using SocialWorld.Business.DTOs.CompanyDtos;

namespace SocialWorld.Business.ValidationRules.FluentValidation
{
    public class CompanyEditDtoValidator : AbstractValidator<CompanyEditDto>
    {
        public CompanyEditDtoValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(I => I.Address).NotEmpty().WithMessage("Adres alanı boş geçilemez");
            RuleFor(I => I.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(I => I.Explanation).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(I => I.PhoneNumber).NotEmpty().WithMessage("Telefon numarası alanı boş geçilemez");
        }
    }
}
