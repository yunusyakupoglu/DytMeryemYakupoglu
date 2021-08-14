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
    public class WorkingHourManager : Service<WorkingHourCreateDto, WorkingHourUpdateDto, WorkingHourListDto, ObjWorkingHour>, IWorkingHourManager
    {
        public WorkingHourManager(IMapper mapper, IValidator<WorkingHourCreateDto> createDtoValidator, IValidator<WorkingHourUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) :
            base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
