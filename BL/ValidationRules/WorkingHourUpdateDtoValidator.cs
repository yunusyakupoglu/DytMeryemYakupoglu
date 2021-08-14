using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class WorkingHourUpdateDtoValidator : AbstractValidator<WorkingHourUpdateDto>
    {
        public WorkingHourUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Day).NotEmpty();
            RuleFor(x => x.Morning).NotEmpty();
            RuleFor(x => x.Afternoon).NotEmpty();
        }
    }
}
