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
        public List<ProvidedServiceListDto> providedServices { get; set; }
        public List<SocialMediaAccountListDto> socialMediaAccounts { get; set; }
        public List<WorkingHourListDto> workingHours { get; set; }
        public List<CommentListDto> Comments { get; set; }
        public List<AboutUsListDto> AboutUsList { get; set; }
        public List<FaqListDto> Faqs { get; set; }
        public List<OnlineDietFaqListDto> OnlineDietFaqs { get; set; }
        public List<OnlineDietInformationListListDto> OnlineDietInformationLists { get; set; }
        public List<WeakenedListDto> WeakenedLists { get; set; }
        public List<PhoneNumberListDto> PhoneNumbers { get; set; }
        public List<FaxNumberListDto> FaxNumbers { get; set; }
    }
}
