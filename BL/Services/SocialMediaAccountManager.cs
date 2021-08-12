using AutoMapper;
using BL.IServices;
using DAL.UnitOfWork;
using DTOs;
using FluentValidation;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class SocialMediaAccountManager : Service<SocialMediaAccountCreateDto, SocialMediaAccountUpdateDto, SocialMediaAccountListDto, ObjSocialMediaAccount>, ISocialMediaAccountManager
    {
        public SocialMediaAccountManager(IMapper mapper, IValidator<SocialMediaAccountCreateDto> createDtoValidator, IValidator<SocialMediaAccountUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) :
            base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
