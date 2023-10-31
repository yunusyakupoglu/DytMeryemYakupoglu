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
    public class PricingManager : Service<PricingCreateDto, PricingUpdateDto, PricingListDto, ObjPricing>, IPricingManager
    {
        public PricingManager(IMapper mapper, IValidator<PricingCreateDto> createDtoValidator, IValidator<PricingUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
