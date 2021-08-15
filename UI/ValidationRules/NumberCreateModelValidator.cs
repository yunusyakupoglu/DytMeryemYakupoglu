using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.ValidationRules
{
    public class NumberCreateModelValidator : AbstractValidator<NumberCreateModel>
    {
        public NumberCreateModelValidator()
        {
            RuleFor(x => x.Definition).NotEmpty();
            RuleFor(x => x.NumberCategoryId).NotEmpty();
        }
    }
}
