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
    public class MailController : Controller
    {
        private readonly IMailManager _mailManager;
        private readonly IValidator<MailCreateDto> _mailCreateDtoValidator;
        private readonly IMapper _mapper;

        public MailController(IMailManager mailManager, IValidator<MailCreateDto> mailCreateDtoValidator, IMapper mapper)
        {
            _mailManager = mailManager;
            _mailCreateDtoValidator = mailCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _mailManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new MailCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MailCreateDto model)
        {
            var result = _mailCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<MailCreateDto>(model);
                var createResponse = await _mailManager.CreateAsync(dto);
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
            var response = await _mailManager.GetByIdAsync<MailUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(MailUpdateDto dto)
        {
            var response = await _mailManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
