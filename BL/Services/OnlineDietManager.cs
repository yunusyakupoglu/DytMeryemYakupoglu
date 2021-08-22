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
    public class OnlineDietManager : Service<OnlineDietCreateDto, OnlineDietUpdateDto, OnlineDietListDto, ObjOnlineDiet>, IOnlineDietManager
    {
        public OnlineDietManager(IMapper mapper, IValidator<OnlineDietCreateDto> createDtoValidator, IValidator<OnlineDietUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
