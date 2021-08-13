using AutoMapper;
using BL.IServices;
using Common;
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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public NumberCategoryManager(IMapper mapper, IValidator<NumberCategoryCreateDto> createDtoValidator, IValidator<NumberCategoryUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) :
            base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResponse<List<NumberCategoryListDto>>> GetActiveAsync()
        {
            var data = await _unitOfWork.GetRepository<ObjNumberCategory>().GetAllAsync(x => x.Status, Common.Enums.OrderByType.DESC);
            var dto = _mapper.Map<List<NumberCategoryListDto>>(data);
            return new Response<List<NumberCategoryListDto>>(ResponseType.Succes, dto);
        }
    }
}
