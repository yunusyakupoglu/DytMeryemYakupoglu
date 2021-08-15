﻿using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class NumberCategoryCreateDtoValidator : AbstractValidator<NumberCategoryCreateDto>
    {
        public NumberCategoryCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty();
            RuleFor(x => x.IconCode).NotEmpty();
        }
    }
}
