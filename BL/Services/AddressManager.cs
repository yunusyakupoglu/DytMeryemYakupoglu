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
    public class AddressManager : Service<AddressCreateDto, AddressUpdateDto, AddressListDto, ObjAddress>, IAddressManager
    {
        public AddressManager(IMapper mapper, IValidator<AddressCreateDto> createDtoValidator, IValidator<AddressUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : 
            base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
        }
    }
}
