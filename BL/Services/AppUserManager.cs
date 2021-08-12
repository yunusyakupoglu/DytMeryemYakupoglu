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
    public class AppUserManager : Service<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, ObjAppUser>, IAppUserManager
    {
        public AppUserManager(IMapper mapper, IValidator<AppUserCreateDto> createDtoValidator, IValidator<AppUserUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) :
            base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
