using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class PhoneNumberCreateDtoValidator : AbstractValidator<PhoneNumberCreateDto>
    {
        public PhoneNumberCreateDtoValidator()
        {
            RuleFor(x => x.Status).NotEmpty();
            RuleFor(x => x.Definition).NotEmpty();
        }
    }
}
