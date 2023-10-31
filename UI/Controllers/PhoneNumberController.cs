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
    public class PhoneNumberController : Controller
    {
        private readonly IPhoneNumberManager _phoneNumberManager;
        private readonly IValidator<PhoneNumberCreateDto> _phoneNumberCreateDtoValidator;
        private readonly IMapper _mapper;

        public PhoneNumberController(IPhoneNumberManager phoneNumberManager, IValidator<PhoneNumberCreateDto> phoneNumberCreateDtoValidator, IMapper mapper)
        {
            _phoneNumberManager = phoneNumberManager;
            _phoneNumberCreateDtoValidator = phoneNumberCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _phoneNumberManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new PhoneNumberCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PhoneNumberCreateDto model)
        {
            var result = _phoneNumberCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<PhoneNumberCreateDto>(model);
                var createResponse = await _phoneNumberManager.CreateAsync(dto);
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
            var response = await _phoneNumberManager.GetByIdAsync<PhoneNumberUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(PhoneNumberUpdateDto dto)
        {
            var response = await _phoneNumberManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
