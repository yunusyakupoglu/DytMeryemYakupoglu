using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class WorkingHourCreateDtoValidator : AbstractValidator<WorkingHourCreateDto>
    {
        public WorkingHourCreateDtoValidator()
        {
            RuleFor(x => x.Day).NotEmpty();
            RuleFor(x => x.Morning).NotEmpty();
            RuleFor(x => x.Afternoon).NotEmpty();
            RuleFor(x => x.Status).NotEmpty();
        }
    }
}
