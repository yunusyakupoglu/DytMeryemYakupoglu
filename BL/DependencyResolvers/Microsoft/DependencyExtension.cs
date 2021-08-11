using AutoMapper;
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

            var mapperConfiguration = new MapperConfiguration(opt =>
            {
                //opt.AddProfile();
            });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

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

            services.AddTransient<IValidator<NumberCategoryCreateDto>, NumberCategoryCreateDtoValidator>();
            services.AddTransient<IValidator<NumberCategoryUpdateDto>, NumberCategoryUpdateDtoValidator>();

            services.AddTransient<IValidator<NumberCreateDto>, NumberCreateDtoValidator>();
            services.AddTransient<IValidator<NumberUpdateDto>, NumberUpdateDtoValidator>();

            services.AddTransient<IValidator<ProvidedServiceCreateDto>, ProvidedServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>, ProvidedServiceUpdateDtoValidator>();

            services.AddTransient<IValidator<SocialMediaAccountCreateDto>, SocialMediaAccountCreateDtoValidator>();
            services.AddTransient<IValidator<SocialMediaAccountUpdateDto>, SocialMediaAccountUpdateDtoValidator>();

            services.AddTransient<IValidator<WorkingHourCreateDto>, WorkingHourCreateDtoValidator>();
            services.AddTransient<IValidator<WorkingHourUpdateDto>, WorkingHourUpdateDtoValidator>();
        }
    }
}
