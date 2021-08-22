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
    public class OnlineDietInformationListController : Controller
    {
        private readonly IOnlineDietInformationListManager _onlineDietInformationListManager;
        private readonly IValidator<OnlineDietInformationListCreateDto> _onlineDietInformationListCreateDtoValidator;
        private readonly IMapper _mapper;

        public OnlineDietInformationListController(IOnlineDietInformationListManager onlineDietInformationListManager, IValidator<OnlineDietInformationListCreateDto> onlineDietInformationListCreateDtoValidator, IMapper mapper)
        {
            _onlineDietInformationListManager = onlineDietInformationListManager;
            _onlineDietInformationListCreateDtoValidator = onlineDietInformationListCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _onlineDietInformationListManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new OnlineDietInformationListCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OnlineDietInformationListCreateDto model)
        {
            var result = _onlineDietInformationListCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<OnlineDietInformationListCreateDto>(model);
                var createResponse = await _onlineDietInformationListManager.CreateAsync(dto);
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
            var response = await _onlineDietInformationListManager.GetByIdAsync<OnlineDietInformationListUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(OnlineDietInformationListUpdateDto dto)
        {
            var response = await _onlineDietInformationListManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
