using AutoMapper;
using BL.IServices;
using BL.Services;
using DTOs;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Extensions;
using UI.Models;

namespace UI.Controllers
{
    public class NumberController : Controller
    {
        private readonly INumberManager _numberManager;
        private readonly INumberCategoryManager _numberCategoryManager;
        private readonly IValidator<NumberCreateDto> _numberCreateDtoValidator;
        private readonly IMapper _mapper;

        public NumberController(INumberManager numberManager, IValidator<NumberCreateDto> numberCreateDtoValidator, IMapper mapper, INumberCategoryManager numberCategoryManager)
        {
            _numberManager = numberManager;
            _numberCreateDtoValidator = numberCreateDtoValidator;
            _mapper = mapper;
            _numberCategoryManager = numberCategoryManager;
        }

        public async Task<IActionResult> Index()
        {
            var numberlist = await _numberCategoryManager.GetAllAsync();
            ViewBag.numberListe = new SelectList(numberlist.Data, "Id", "Definition");
            var response = await _numberManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public async Task<IActionResult> Create()
        {
            //var model = new NumberCreateDto();
            //var numberlist = await _numberCategoryManager.GetAllAsync();
            //ViewBag.numberListe = new SelectList(numberlist.Data, "Id", "Definition");
            var response = await _numberCategoryManager.GetAllAsync();
            var model = new NumberCreateModel
            {
                NumberCategories = new SelectList(response.Data, "Id", "Definition")
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(NumberCreateDto model)
        {
            var result = _numberCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<NumberCreateDto>(model);
                var createResponse = await _numberManager.CreateAsync(dto);
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
            var response = await _numberManager.GetByIdAsync<NumberUpdateDto>(id);
            var responseCategory = await _numberCategoryManager.GetAllAsync();
            var model = new NumberUpdateDto
            {
                NumberCategories = new SelectList(responseCategory.Data, "Id", "Definition")
            };
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(NumberUpdateDto dto)
        {
            var response = await _numberManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
