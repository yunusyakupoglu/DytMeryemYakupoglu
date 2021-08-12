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
    public class MailManager : Service<MailCreateDto, MailUpdateDto, MailListDto, ObjMail>, IMailManager
    {
        public MailManager(IMapper mapper, IValidator<MailCreateDto> createDtoValidator, IValidator<MailUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) :
            base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
