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
    public class OnlineDietController : Controller
    {
        private readonly IOnlineDietManager _onlineDietManager;
        private readonly IValidator<OnlineDietCreateDto> _onlineDietCreateDtoValidator;
        private readonly IMapper _mapper;

        public OnlineDietController(IOnlineDietManager onlineDietManager, IValidator<OnlineDietCreateDto> onlineDietCreateDtoValidator, IMapper mapper)
        {
            _onlineDietManager = onlineDietManager;
            _onlineDietCreateDtoValidator = onlineDietCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _onlineDietManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new OnlineDietCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OnlineDietCreateDto model)
        {
            var result = _onlineDietCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<OnlineDietCreateDto>(model);
                var createResponse = await _onlineDietManager.CreateAsync(dto);
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
            var response = await _onlineDietManager.GetByIdAsync<OnlineDietUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(OnlineDietUpdateDto dto)
        {
            var response = await _onlineDietManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
