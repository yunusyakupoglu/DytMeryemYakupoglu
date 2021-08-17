using AutoMapper;
using BL.IServices;
using DTOs;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Extensions;
using UI.Models;

namespace UI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogManager _blogManager;
        private readonly IValidator<BlogCreateDto> _blogCreateDtoValidator;
        private readonly IValidator<BlogUpdateDto> _blogUpdateDtoValidator;
        private readonly IMapper _mapper;

        public BlogController(IBlogManager blogManager, IValidator<BlogCreateDto> blogCreateDtoValidator, IValidator<BlogUpdateDto> blogUpdateDtoValidator, IMapper mapper)
        {
            _blogManager = blogManager;
            _blogCreateDtoValidator = blogCreateDtoValidator;
            _blogUpdateDtoValidator = blogUpdateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _blogManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new BlogCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BlogCreateDto model)
        {
            var result = _blogCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<BlogCreateDto>(model);
                dto.ImagePath = _blogManager.UploadImage(dto.FileDoc);
                var createResponse = await _blogManager.CreateAsync(dto);
                return this.ResponseRedirectAction(createResponse, "Index");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return View(model);
        }

        public async Task<IActionResult> Update(int id)
        {
            var response = await _blogManager.GetByIdAsync<BlogUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(BlogUpdateDto dto)
        {
            var result = _blogUpdateDtoValidator.Validate(dto);
            if (result.IsValid)
            {
                if (dto.FileDoc != null)
                {
                    _blogManager.DeleteImage(dto.ImagePath);
                    dto.ImagePath = _blogManager.UploadImage(dto.FileDoc);
                    var createResponse = await _blogManager.UpdateAsync(dto);
                    return this.ResponseRedirectAction(createResponse, "Index");
                }
                else
                {
                    var createResponse = await _blogManager.UpdateAsync(dto);
                    return this.ResponseRedirectAction(createResponse, "Index");
                }

            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return View(dto);
        }
    }
}
