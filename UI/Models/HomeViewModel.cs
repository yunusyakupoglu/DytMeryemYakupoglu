using DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class HomeViewModel
    {
        public List<AddressListDto> addresses { get; set; }
        public List<AndulasyonListDto> andulasyons { get; set; }
        public List<BlogListDto> blogs { get; set; }
        public List<MailListDto> mails { get; set; }
        public List<NumberListDto> numbers { get; set; }
        public List<NumberCategoryListDto> numberCategories { get; set; }
        public List<ProvidedServiceListDto> providedServices { get; set; }
        public List<SocialMediaAccountListDto> socialMediaAccounts { get; set; }
        public List<WorkingHourListDto> workingHours { get; set; }
    }
}
