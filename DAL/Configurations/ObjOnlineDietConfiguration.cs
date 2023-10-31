using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class ObjOnlineDietConfiguration : IEntityTypeConfiguration<ObjOnlineDiet>
    {
        public void Configure(EntityTypeBuilder<ObjOnlineDiet> builder)
        {
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.InstagramAccount).IsRequired();
            builder.Property(x => x.Job).IsRequired();
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Size).IsRequired();
            builder.Property(x => x.Weight).IsRequired();
            builder.Property(x => x.TargetWeight).IsRequired();
            builder.Property(x => x.NumberOfMeals).IsRequired();
            builder.Property(x => x.FavoriteFoods).IsRequired();
            builder.Property(x => x.HateFoods).IsRequired();
            builder.Property(x => x.AllergicFoods).IsRequired();
            builder.Property(x => x.WeightReason).IsRequired();
            builder.Property(x => x.DailyNutrition).IsRequired();
            builder.Property(x => x.PersonalInformation).IsRequired();
            builder.Property(x => x.HealthProblem).IsRequired();
            builder.Property(x => x.UseMedicine).IsRequired();
            builder.Property(x => x.SpecialCase).IsRequired();
            builder.Property(x => x.ReferencePerson).IsRequired();
            builder.Property(x => x.SharePhotos).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
