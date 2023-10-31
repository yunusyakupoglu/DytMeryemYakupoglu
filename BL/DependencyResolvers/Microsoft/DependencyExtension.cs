using AutoMapper;
using BL.IServices;
using BL.Mappings.AutoMapper;
using BL.Services;
using BL.ValidationRules;
using DAL;
using DAL.UnitOfWork;
using DTOs;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Default"));
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IValidator<AddressCreateDto>, AddressCreateDtoValidator>();
            services.AddTransient<IValidator<AddressUpdateDto>, AddressUpdateDtoValidator>();

            services.AddTransient<IValidator<AppRoleCreateDto>, AppRoleCreateDtoValidator>();
            services.AddTransient<IValidator<AppRoleUpdateDto>, AppRoleUpdateDtoValidator>();

            services.AddTransient<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();

            services.AddTransient<IValidator<BlogAppUserStatusCreateDto>, BlogAppUserStatusCreateDtoValidator>();
            services.AddTransient<IValidator<BlogAppUserStatusUpdateDto>, BlogAppUserStatusUpdateDtoValidator>();

            services.AddTransient<IValidator<BlogCreateDto>, BlogCreateDtoValidator>();
            services.AddTransient<IValidator<BlogUpdateDto>, BlogUpdateDtoValidator>();

            services.AddTransient<IValidator<CategoryCreateDto>, CategoryCreateDtoValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateDtoValidator>();

            services.AddTransient<IValidator<MailCreateDto>, MailCreateDtoValidator>();
            services.AddTransient<IValidator<MailUpdateDto>, MailUpdateDtoValidator>();

            services.AddTransient<IValidator<ProvidedServiceCreateDto>, ProvidedServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>, ProvidedServiceUpdateDtoValidator>();

            services.AddTransient<IValidator<SocialMediaAccountCreateDto>, SocialMediaAccountCreateDtoValidator>();
            services.AddTransient<IValidator<SocialMediaAccountUpdateDto>, SocialMediaAccountUpdateDtoValidator>();

            services.AddTransient<IValidator<WorkingHourCreateDto>, WorkingHourCreateDtoValidator>();
            services.AddTransient<IValidator<WorkingHourUpdateDto>, WorkingHourUpdateDtoValidator>();

            services.AddTransient<IValidator<AndulasyonCreateDto>, AndulasyonCreateDtoValidator>();
            services.AddTransient<IValidator<AndulasyonUpdateDto>, AndulasyonUpdateDtoValidator>();

            services.AddTransient<IValidator<CommentCreateDto>, CommentCreateDtoValidator>();
            services.AddTransient<IValidator<CommentUpdateDto>, CommentUpdateDtoValidator>();

            services.AddTransient<IValidator<PricingCreateDto>, PricingCreateDtoValidator>();
            services.AddTransient<IValidator<PricingUpdateDto>, PricingUpdateDtoValidator>();

            services.AddTransient<IValidator<OnlineDietCreateDto>, OnlineDietCreateDtoValidator>();
            services.AddTransient<IValidator<OnlineDietUpdateDto>, OnlineDietUpdateDtoValidator>();

            services.AddTransient<IValidator<WeakenedCreateDto>, WeakenedCreateDtoValidator>();
            services.AddTransient<IValidator<WeakenedUpdateDto>, WeakenedUpdateDtoValidator>();

            services.AddTransient<IValidator<AboutUsCreateDto>, AboutUsCreateDtoValidator>();
            services.AddTransient<IValidator<AboutUsUpdateDto>, AboutUsUpdateDtoValidator>();

            services.AddTransient<IValidator<FaqCreateDto>, FaqCreateDtoValidator>();
            services.AddTransient<IValidator<FaqUpdateDto>, FaqUpdateDtoValidator>();

            services.AddTransient<IValidator<OnlineDietFaqCreateDto>, OnlineDietFaqCreateDtoValidator>();
            services.AddTransient<IValidator<OnlineDietFaqUpdateDto>, OnlineDietFaqUpdateDtoValidator>();

            services.AddTransient<IValidator<OnlineDietInformationListCreateDto>, OnlineDietInformationListCreateDtoValidator>();
            services.AddTransient<IValidator<OnlineDietInformationListUpdateDto>, OnlineDietInformationListUpdateDtoValidator>();

            services.AddTransient<IValidator<FaxNumberCreateDto>, FaxNumberCreateDtoValidator>();
            services.AddTransient<IValidator<FaxNumberUpdateDto>, FaxNumberUpdateDtoValidator>();

            services.AddTransient<IValidator<PhoneNumberCreateDto>, PhoneNumberCreateDtoValidator>();
            services.AddTransient<IValidator<PhoneNumberUpdateDto>, PhoneNumberUpdateDtoValidator>();

            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();


            services.AddScoped<IAddressManager, AddressManager>();
            services.AddScoped<IAppRoleManager, AppRoleManager>();
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IBlogAppUserStatusManager, BlogAppUserStatusManager>();
            services.AddScoped<IBlogManager, BlogManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IMailManager, MailManager>();
            services.AddScoped<IProvidedServiceManager, ProvidedServiceManager>();
            services.AddScoped<ISocialMediaAccountManager, SocialMediaAccountManager>();
            services.AddScoped<IWorkingHourManager, WorkingHourManager>();
            services.AddScoped<IAndulasyonManager, AndulasyonManager>();
            services.AddScoped<ICommentManager, CommentManager>();
            services.AddScoped<IPricingManager, PricingManager>();
            services.AddScoped<IOnlineDietManager, OnlineDietManager>();
            services.AddScoped<IWeakenedManager, WeakenedManager>();
            services.AddScoped<IAboutUsManager, AboutUsManager>();
            services.AddScoped<IFaqManager, FaqManager>();
            services.AddScoped<IOnlineDietFaqManager, OnlineDietFaqManager>();
            services.AddScoped<IOnlineDietInformationListManager, OnlineDietInformationListManager>();
            services.AddScoped<IFaxNumberManager, FaxNumberManager>();
            services.AddScoped<IPhoneNumberManager, PhoneNumberManager>();
        }
    }
}
