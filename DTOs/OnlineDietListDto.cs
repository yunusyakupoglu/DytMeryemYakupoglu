using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class OnlineDietListDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string InstagramAccount { get; set; }
        public string Job { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string TargetWeight { get; set; }
        public string NumberOfMeals { get; set; }
        public string FavoriteFoods { get; set; }
        public string HateFoods { get; set; }
        public string AllergicFoods { get; set; }
        public string WeightReason { get; set; }
        public string DailyNutrition { get; set; }
        public string PersonalInformation { get; set; }
        public string HealthProblem { get; set; }
        public string UseMedicine { get; set; }
        public string SpecialCase { get; set; }
        public string ReferencePerson { get; set; }
        public string SharePhotos { get; set; }
        public bool Status { get; set; }
    }
}
