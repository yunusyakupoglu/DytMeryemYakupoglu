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

            CreateMap<NumberCategoryCreateDto, ObjNumberCategory>().ReverseMap();
            CreateMap<NumberCategoryListDto, ObjNumberCategory>().ReverseMap();
            CreateMap<NumberCategoryUpdateDto, ObjNumberCategory>().ReverseMap();

            CreateMap<NumberCreateDto, ObjNumber>().ReverseMap();
            CreateMap<NumberListDto, ObjNumber>().ReverseMap();
            CreateMap<NumberUpdateDto, ObjNumber>().ReverseMap();

            CreateMap<ProvidedServiceCreateDto, ObjProvidedService>().ReverseMap();
            CreateMap<ProvidedServiceListDto, ObjProvidedService>().ReverseMap();
            CreateMap<ProvidedServiceUpdateDto, ObjProvidedService>().ReverseMap();

            CreateMap<SocialMediaAccountCreateDto, ObjSocialMediaAccount>().ReverseMap();
            CreateMap<SocialMediaAccountListDto, ObjSocialMediaAccount>().ReverseMap();
            CreateMap<SocialMediaAccountUpdateDto, ObjSocialMediaAccount>().ReverseMap();

            CreateMap<WorkingHourCreateDto, ObjWorkingHour>().ReverseMap();
            CreateMap<WorkingHourListDto, ObjWorkingHour>().ReverseMap();
            CreateMap<WorkingHourUpdateDto, ObjWorkingHour>().ReverseMap();
        }
    }
}
