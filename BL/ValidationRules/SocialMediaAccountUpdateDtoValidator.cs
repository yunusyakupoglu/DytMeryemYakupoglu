using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class SocialMediaAccountUpdateDtoValidator : AbstractValidator<SocialMediaAccountUpdateDto>
    {
        public SocialMediaAccountUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Url).NotEmpty();
            RuleFor(x => x.IconCode).NotEmpty();
        }
    }
}
