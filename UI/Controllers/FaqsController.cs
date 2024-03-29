﻿using AutoMapper;
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
    public class FaqsController : Controller
    {
        private readonly IFaqManager _faqManager;
        private readonly IValidator<FaqCreateDto> _faqCreateDtoValidator;
        private readonly IMapper _mapper;

        public FaqsController(IFaqManager faqManager, IValidator<FaqCreateDto> faqCreateDtoValidator, IMapper mapper)
        {
            _faqManager = faqManager;
            _faqCreateDtoValidator = faqCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _faqManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new FaqCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(FaqCreateDto model)
        {
            var result = _faqCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<FaqCreateDto>(model);
                var createResponse = await _faqManager.CreateAsync(dto);
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
            var response = await _faqManager.GetByIdAsync<FaqUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(FaqUpdateDto dto)
        {
            var response = await _faqManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
