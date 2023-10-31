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
    public class FaxNumberManager : Service<FaxNumberCreateDto, FaxNumberUpdateDto, FaxNumberListDto, ObjFaxNumber>, IFaxNumberManager
    {
        public FaxNumberManager(IMapper mapper, IValidator<FaxNumberCreateDto> createDtoValidator, IValidator<FaxNumberUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
