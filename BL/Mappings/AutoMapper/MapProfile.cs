using AutoMapper;
using DTOs;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mappings.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AddressCreateDto, ObjAddress>().ReverseMap();
            CreateMap<AddressListDto, ObjAddress>().ReverseMap();
            CreateMap<AddressUpdateDto, ObjAddress>().ReverseMap();

            CreateMap<AppRoleCreateDto, ObjAppRole>().ReverseMap();
            CreateMap<AppRoleListDto, ObjAppRole>().ReverseMap();
            CreateMap<AppRoleUpdateDto, ObjAppRole>().ReverseMap();

            CreateMap<AppUserCreateDto, ObjAppUser>().ReverseMap();
            CreateMap<AppUserListDto, ObjAppUser>().ReverseMap();
            CreateMap<AppUserUpdateDto, ObjAppUser>().ReverseMap();

            CreateMap<BlogAppUserStatusCreateDto, ObjBlogAppUserStatus>().ReverseMap();
            CreateMap<BlogAppUserStatusListDto, ObjBlogAppUserStatus>().ReverseMap();
            CreateMap<BlogAppUserStatusUpdateDto, ObjBlogAppUserStatus>().ReverseMap();

            CreateMap<CategoryCreateDto, ObjCategory>().ReverseMap();
            CreateMap<CategoryListDto, ObjCategory>().ReverseMap();
            CreateMap<CategoryUpdateDto, ObjCategory>().ReverseMap();

            CreateMap<MailCreateDto, ObjMail>().ReverseMap();
            CreateMap<MailListDto, ObjMail>().ReverseMap();
            CreateMap<MailUpdateDto, ObjMail>().ReverseMap();

            CreateMap<ProvidedServiceCreateDto, ObjProvidedService>().ReverseMap();
            CreateMap<ProvidedServiceListDto, ObjProvidedService>().ReverseMap();
            CreateMap<ProvidedServiceUpdateDto, ObjProvidedService>().ReverseMap();

            CreateMap<SocialMediaAccountCreateDto, ObjSocialMediaAccount>().ReverseMap();
            CreateMap<SocialMediaAccountListDto, ObjSocialMediaAccount>().ReverseMap();
            CreateMap<SocialMediaAccountUpdateDto, ObjSocialMediaAccount>().ReverseMap();

            CreateMap<WorkingHourCreateDto, ObjWorkingHour>().ReverseMap();
            CreateMap<WorkingHourListDto, ObjWorkingHour>().ReverseMap();
            CreateMap<WorkingHourUpdateDto, ObjWorkingHour>().ReverseMap();

            CreateMap<BlogCreateDto, ObjBlog>().ReverseMap();
            CreateMap<BlogListDto, ObjBlog>().ReverseMap();
            CreateMap<BlogUpdateDto, ObjBlog>().ReverseMap();

            CreateMap<AndulasyonCreateDto, ObjAndulasyon>().ReverseMap();
            CreateMap<AndulasyonListDto, ObjAndulasyon>().ReverseMap();
            CreateMap<AndulasyonUpdateDto, ObjAndulasyon>().ReverseMap();

            CreateMap<CommentCreateDto, ObjComment>().ReverseMap();
            CreateMap<CommentListDto, ObjComment>().ReverseMap();
            CreateMap<CommentUpdateDto, ObjComment>().ReverseMap();

            CreateMap<PricingCreateDto, ObjPricing>().ReverseMap();
            CreateMap<PricingListDto, ObjPricing>().ReverseMap();
            CreateMap<PricingUpdateDto, ObjPricing>().ReverseMap();

            CreateMap<OnlineDietCreateDto, ObjOnlineDiet>().ReverseMap();
            CreateMap<OnlineDietListDto, ObjOnlineDiet>().ReverseMap();
            CreateMap<OnlineDietUpdateDto, ObjOnlineDiet>().ReverseMap();

            CreateMap<WeakenedCreateDto, ObjWeakened>().ReverseMap();
            CreateMap<WeakenedListDto, ObjWeakened>().ReverseMap();
            CreateMap<WeakenedUpdateDto, ObjWeakened>().ReverseMap();

            CreateMap<AboutUsCreateDto, ObjAboutUs>().ReverseMap();
            CreateMap<AboutUsListDto, ObjAboutUs>().ReverseMap();
            CreateMap<AboutUsUpdateDto, ObjAboutUs>().ReverseMap();

            CreateMap<FaqCreateDto, ObjFaq>().ReverseMap();
            CreateMap<FaqListDto, ObjFaq>().ReverseMap();
            CreateMap<FaqUpdateDto, ObjFaq>().ReverseMap();

            CreateMap<OnlineDietFaqCreateDto, ObjOnlineDietFaq>().ReverseMap();
            CreateMap<OnlineDietFaqListDto, ObjOnlineDietFaq>().ReverseMap();
            CreateMap<OnlineDietFaqUpdateDto, ObjOnlineDietFaq>().ReverseMap();

            CreateMap<OnlineDietInformationListCreateDto, ObjOnlineDietInformationList>().ReverseMap();
            CreateMap<OnlineDietInformationListListDto, ObjOnlineDietInformationList>().ReverseMap();
            CreateMap<OnlineDietInformationListUpdateDto, ObjOnlineDietInformationList>().ReverseMap();

            CreateMap<FaxNumberCreateDto, ObjFaxNumber>().ReverseMap();
            CreateMap<FaxNumberListDto, ObjFaxNumber>().ReverseMap();
            CreateMap<FaxNumberUpdateDto, ObjFaxNumber>().ReverseMap();

            CreateMap<PhoneNumberCreateDto, ObjPhoneNumber>().ReverseMap();
            CreateMap<PhoneNumberListDto, ObjPhoneNumber>().ReverseMap();
            CreateMap<PhoneNumberUpdateDto, ObjPhoneNumber>().ReverseMap();
        }
    }
}
