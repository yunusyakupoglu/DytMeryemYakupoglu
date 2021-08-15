using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.ValidationRules
{
    public class BlogCreateModelValidator : AbstractValidator<BlogCreateModel>
    {
        public BlogCreateModelValidator()
        {
            //RuleFor
        }
    }
}
