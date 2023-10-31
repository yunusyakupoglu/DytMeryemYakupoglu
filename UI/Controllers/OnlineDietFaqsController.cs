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
    public class OnlineDietFaqsController : Controller
    {
        private readonly IOnlineDietFaqManager _onlineDietFaqManager;
        private readonly IValidator<OnlineDietFaqCreateDto> _onlineDietFaqCreateDtoValidator;
        private readonly IMapper _mapper;

        public OnlineDietFaqsController(IOnlineDietFaqManager onlineDietFaqManager, IValidator<OnlineDietFaqCreateDto> onlineDietFaqCreateDtoValidator, IMapper mapper)
        {
            _onlineDietFaqManager = onlineDietFaqManager;
            _onlineDietFaqCreateDtoValidator = onlineDietFaqCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _onlineDietFaqManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new OnlineDietFaqCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OnlineDietFaqCreateDto model)
        {
            var result = _onlineDietFaqCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<OnlineDietFaqCreateDto>(model);
                var createResponse = await _onlineDietFaqManager.CreateAsync(dto);
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
            var response = await _onlineDietFaqManager.GetByIdAsync<OnlineDietFaqUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(OnlineDietFaqUpdateDto dto)
        {
            var response = await _onlineDietFaqManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
