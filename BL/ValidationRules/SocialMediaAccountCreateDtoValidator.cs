using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class SocialMediaAccountCreateDtoValidator : AbstractValidator<SocialMediaAccountCreateDto>
    {
        public SocialMediaAccountCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Url).NotEmpty();
            RuleFor(x => x.IconCode).NotEmpty();
            RuleFor(x => x.Status).NotEmpty();
        }
    }
}
