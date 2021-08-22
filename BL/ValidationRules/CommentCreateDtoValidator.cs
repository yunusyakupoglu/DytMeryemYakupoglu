using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class CommentCreateDtoValidator : AbstractValidator<CommentCreateDto>
    {
        public CommentCreateDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.Lastname).NotEmpty();
            RuleFor(x => x.EMail).NotEmpty();
            RuleFor(x => x.InstagramAccount).NotEmpty();
            RuleFor(x => x.Job).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Status).NotEmpty();
        }
    }
}
