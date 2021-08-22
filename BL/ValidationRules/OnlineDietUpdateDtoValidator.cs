using DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ValidationRules
{
    public class OnlineDietUpdateDtoValidator : AbstractValidator<OnlineDietUpdateDto>
    {
        public OnlineDietUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.InstagramAccount).NotEmpty();
            RuleFor(x => x.Job).NotEmpty();
            RuleFor(x => x.Age).NotEmpty();
            RuleFor(x => x.Gender).NotEmpty();
            RuleFor(x => x.Size).NotEmpty();
            RuleFor(x => x.Weight).NotEmpty();
            RuleFor(x => x.TargetWeight).NotEmpty();
            RuleFor(x => x.NumberOfMeals).NotEmpty();
            RuleFor(x => x.FavoriteFoods).NotEmpty();
            RuleFor(x => x.HateFoods).NotEmpty();
            RuleFor(x => x.AllergicFoods).NotEmpty();
            RuleFor(x => x.WeightReason).NotEmpty();
            RuleFor(x => x.DailyNutrition).NotEmpty();
            RuleFor(x => x.PersonalInformation).NotEmpty();
            RuleFor(x => x.HealthProblem).NotEmpty();
            RuleFor(x => x.UseMedicine).NotEmpty();
            RuleFor(x => x.SpecialCase).NotEmpty();
            RuleFor(x => x.ReferencePerson).NotEmpty();
            RuleFor(x => x.SharePhotos).NotEmpty();
        }
    }
}
