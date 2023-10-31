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
    public class AboutUsManager : Service<AboutUsCreateDto, AboutUsUpdateDto, AboutUsListDto, ObjAboutUs>, IAboutUsManager
    {
        public AboutUsManager(IMapper mapper, IValidator<AboutUsCreateDto> createDtoValidator, IValidator<AboutUsUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
