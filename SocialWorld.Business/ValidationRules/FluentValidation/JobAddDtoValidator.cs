﻿using FluentValidation;
using SocialWorld.Business.DTOs.JobDtos;

namespace SocialWorld.Business.ValidationRules.FluentValidation
{
    public class JobAddDtoValidator : AbstractValidator<JobAddDto>
    {
        public JobAddDtoValidator()
        {
            RuleFor(I => I.Explanation).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(I => I.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(I => I.Explanation).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(I => I.Explanation).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
