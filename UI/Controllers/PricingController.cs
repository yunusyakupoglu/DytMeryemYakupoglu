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
    public class PricingController : Controller
    {
        private readonly IPricingManager _pricingManager;
        private readonly IValidator<PricingCreateDto> _pricingCreateDtoValidator;
        private readonly IMapper _mapper;

        public PricingController(IPricingManager pricingManager, IValidator<PricingCreateDto> pricingCreateDtoValidator, IMapper mapper)
        {
            _pricingManager = pricingManager;
            _pricingCreateDtoValidator = pricingCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _pricingManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new PricingCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PricingCreateDto model)
        {
            var result = _pricingCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<PricingCreateDto>(model);
                var createResponse = await _pricingManager.CreateAsync(dto);
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
            var response = await _pricingManager.GetByIdAsync<PricingUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(PricingUpdateDto dto)
        {
            var response = await _pricingManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
