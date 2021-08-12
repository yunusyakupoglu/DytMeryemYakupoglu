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
    public class NumberCategoryManager : Service<NumberCategoryCreateDto, NumberCategoryUpdateDto, NumberCategoryListDto, ObjNumberCategory>, INumberCategoryManager
    {
        public NumberCategoryManager(IMapper mapper, IValidator<NumberCategoryCreateDto> createDtoValidator, IValidator<NumberCategoryUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) :
            base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
