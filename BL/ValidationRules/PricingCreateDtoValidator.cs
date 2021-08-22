using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class PricingCreateDtoValidator : AbstractValidator<PricingCreateDto>
    {
        public PricingCreateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Price).NotEmpty();
            RuleFor(x => x.Status).NotEmpty();
        }
    }
}
