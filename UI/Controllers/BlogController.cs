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
        private readonly ICategoryManager _categoryManager;
        private readonly IValidator<BlogCreateDto> _blogCreateDtoValidator;
        private readonly IValidator<BlogUpdateDto> _blogUpdateDtoValidator;
        private readonly IValidator<BlogCreateModel> _blogCreateModelValidator;
        private readonly IMapper _mapper;

        public BlogController(IBlogManager blogManager, IValidator<BlogCreateDto> blogCreateDtoValidator, IValidator<BlogUpdateDto> blogUpdateDtoValidator, IMapper mapper, ICategoryManager categoryManager, IValidator<BlogCreateModel> blogCreateModelValidator)
        {
            _blogManager = blogManager;
            _blogCreateDtoValidator = blogCreateDtoValidator;
            _blogUpdateDtoValidator = blogUpdateDtoValidator;
            _mapper = mapper;
            _categoryManager = categoryManager;
            _blogCreateModelValidator = blogCreateModelValidator;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _blogManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public async Task<IActionResult> Create()
        {
            var response = await _categoryManager.GetAllAsync();
            var model = new BlogCreateModel
            {
                Categories = new SelectList(response.Data, "Id", "Definition")
            };
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
