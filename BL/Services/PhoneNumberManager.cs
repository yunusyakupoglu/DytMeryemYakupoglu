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
    public class PhoneNumberManager : Service<PhoneNumberCreateDto, PhoneNumberUpdateDto, PhoneNumberListDto, ObjPhoneNumber>, IPhoneNumberManager
    {
        public PhoneNumberManager(IMapper mapper, IValidator<PhoneNumberCreateDto> createDtoValidator, IValidator<PhoneNumberUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
