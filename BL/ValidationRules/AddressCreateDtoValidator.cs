using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class AddressCreateDtoValidator : AbstractValidator<AddressCreateDto>
    {
        public AddressCreateDtoValidator()
        {
            RuleFor(x => x.Coordinate).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Status).NotEmpty();
        }
    }
}
