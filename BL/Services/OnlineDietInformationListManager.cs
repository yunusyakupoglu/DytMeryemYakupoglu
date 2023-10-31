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
    public class OnlineDietInformationListManager : Service<OnlineDietInformationListCreateDto, OnlineDietInformationListUpdateDto, OnlineDietInformationListListDto, ObjOnlineDietInformationList>, IOnlineDietInformationListManager
    {
        public OnlineDietInformationListManager(IMapper mapper, IValidator<OnlineDietInformationListCreateDto> createDtoValidator, IValidator<OnlineDietInformationListUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
