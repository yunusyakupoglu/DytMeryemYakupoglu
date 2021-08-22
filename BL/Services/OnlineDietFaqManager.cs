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
    public class OnlineDietFaqManager : Service<OnlineDietFaqCreateDto, OnlineDietFaqUpdateDto, OnlineDietFaqListDto, ObjOnlineDietFaq>, IOnlineDietFaqManager
    {
        public OnlineDietFaqManager(IMapper mapper, IValidator<OnlineDietFaqCreateDto> createDtoValidator, IValidator<OnlineDietFaqUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
