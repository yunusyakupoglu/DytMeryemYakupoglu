﻿using AutoMapper;
using BL.IServices;
using DTOs;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Extensions;
using UI.Models;

namespace UI.Controllers
{
    [Authorize]
    public class ProvidedServiceController : Controller
    {
        private readonly IProvidedServiceManager _providedServiceManager;
        private readonly IValidator<ProvidedServiceCreateDto> _providedServiceCreateDtoValidator;
        private readonly IMapper _mapper;

        public ProvidedServiceController(IProvidedServiceManager providedServiceManager, IMapper mapper, IValidator<ProvidedServiceCreateDto> providedServiceCreateDtoValidator)
        {
            _providedServiceManager = providedServiceManager;
            _mapper = mapper;
            _providedServiceCreateDtoValidator = providedServiceCreateDtoValidator;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _providedServiceManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new ProvidedServiceCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProvidedServiceCreateDto model)
        {
            var result = _providedServiceCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<ProvidedServiceCreateDto>(model);
                var createResponse = await _providedServiceManager.CreateAsync(dto);
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
            var response = await _providedServiceManager.GetByIdAsync<ProvidedServiceUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProvidedServiceUpdateDto dto)
        {
            var response = await _providedServiceManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
