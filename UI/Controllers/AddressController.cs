using AutoMapper;
using BL.IServices;
using BL.ValidationRules;
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
    public class AddressController : Controller
    {
        private readonly IAddressManager _addressManager;
        private readonly IValidator<AddressCreateDto> _addressCreateDtoValidator;
        private readonly IMapper _mapper;


        public AddressController(IAddressManager addressManager, IValidator<AddressCreateDto> addressCreateDtoValidator, IMapper mapper)
        {
            _addressManager = addressManager;
            _addressCreateDtoValidator = addressCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _addressManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new AddressCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddressCreateDto model)
        {
            var result = _addressCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<AddressCreateDto>(model);
                var createResponse = await _addressManager.CreateAsync(dto);
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
            var response = await _addressManager.GetByIdAsync<AddressUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AddressUpdateDto dto)
        {
            var response = await _addressManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
