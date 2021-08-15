using AutoMapper;
using BL.IServices;
using DTOs;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Extensions;

namespace UI.Controllers
{
    public class NumberCategoryController : Controller
    {
        private readonly INumberCategoryManager _numberCategoryManager;
        private readonly IValidator<NumberCategoryCreateDto> _numberCategoryCreateDtoValidator;
        private readonly IMapper _mapper;

        public NumberCategoryController(INumberCategoryManager numberCategoryManager, IValidator<NumberCategoryCreateDto> numberCategoryCreateDtoValidator, IMapper mapper)
        {
            _numberCategoryManager = numberCategoryManager;
            _numberCategoryCreateDtoValidator = numberCategoryCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _numberCategoryManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new NumberCategoryCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(NumberCategoryCreateDto model)
        {
            var result = _numberCategoryCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<NumberCategoryCreateDto>(model);
                var createResponse = await _numberCategoryManager.CreateAsync(dto);
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
            var response = await _numberCategoryManager.GetByIdAsync<NumberCategoryUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(NumberCategoryUpdateDto dto)
        {
            var response = await _numberCategoryManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
