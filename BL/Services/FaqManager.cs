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
    public class FaqManager : Service<FaqCreateDto, FaqUpdateDto, FaqListDto, ObjFaq>, IFaqManager
    {
        public FaqManager(IMapper mapper, IValidator<FaqCreateDto> createDtoValidator, IValidator<FaqUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
