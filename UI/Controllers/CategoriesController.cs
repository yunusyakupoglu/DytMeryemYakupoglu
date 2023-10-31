using AutoMapper;
using BL.IServices;
using DTOs;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Extensions;

namespace UI.Controllers
{
    [Authorize]
    public class CategoriesController : Controller
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IValidator<CategoryCreateDto> _categoryCreateDtoValidator;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryManager categoryManager, IMapper mapper, IValidator<CategoryCreateDto> categoryCreateDtoValidator)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;
            _categoryCreateDtoValidator = categoryCreateDtoValidator;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _categoryManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new CategoryCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateDto model)
        {
            var result = _categoryCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<CategoryCreateDto>(model);
                var createResponse = await _categoryManager.CreateAsync(dto);
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
            var response = await _categoryManager.GetByIdAsync<CategoryUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto dto)
        {
            var response = await _categoryManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
