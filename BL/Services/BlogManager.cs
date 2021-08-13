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
    public class BlogManager : Service<BlogCreateDto, BlogUpdateDto, BlogListDto, ObjBlog>, IBlogManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BlogManager(IMapper mapper, IValidator<BlogCreateDto> createDtoValidator, IValidator<BlogUpdateDto> updateDtoValidator, IUnitOfWork unitOfWork) : 
            base(mapper, createDtoValidator, updateDtoValidator, unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResponse<List<BlogListDto>>> GetActiveAsync()
        {

            var data = await _unitOfWork.GetRepository<ObjBlog>().GetAllAsync(x => x.Status, x => x.CreatedDate, Common.Enums.OrderByType.DESC);
            var dto = _mapper.Map<List<BlogListDto>>(data);
            return new Response<List<BlogListDto>>(ResponseType.Succes, dto);
        }
    }
}
