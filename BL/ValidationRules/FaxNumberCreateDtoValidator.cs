using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class FaxNumberCreateDtoValidator : AbstractValidator<FaxNumberCreateDto>
    {
        public FaxNumberCreateDtoValidator()
        {
            RuleFor(x => x.Status).NotEmpty();
            RuleFor(x => x.Definition).NotEmpty();
        }
    }
}
