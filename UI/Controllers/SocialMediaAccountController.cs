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
    public class SocialMediaAccountController : Controller
    {
        private readonly ISocialMediaAccountManager _socialMediaAccountManager;
        private readonly IValidator<SocialMediaAccountCreateDto> _sociaMediaAccountCreateDtoValidator;
        private readonly IMapper _mapper;

        public SocialMediaAccountController(ISocialMediaAccountManager socialMediaAccountManager, IValidator<SocialMediaAccountCreateDto> sociaMediaAccountCreateDtoValidator, IMapper mapper)
        {
            _socialMediaAccountManager = socialMediaAccountManager;
            _sociaMediaAccountCreateDtoValidator = sociaMediaAccountCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _socialMediaAccountManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new SocialMediaAccountCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SocialMediaAccountCreateDto model)
        {
            var result = _sociaMediaAccountCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<SocialMediaAccountCreateDto>(model);
                var createResponse = await _socialMediaAccountManager.CreateAsync(dto);
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
            var response = await _socialMediaAccountManager.GetByIdAsync<SocialMediaAccountUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SocialMediaAccountUpdateDto dto)
        {
            var response = await _socialMediaAccountManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
