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
    public class FaxNumberController : Controller
    {
        private readonly IFaxNumberManager _faxNumberManager;
        private readonly IValidator<FaxNumberCreateDto> _faxNumberCreateDtoValidator;
        private readonly IMapper _mapper;

        public FaxNumberController(IFaxNumberManager faxNumberManager, IValidator<FaxNumberCreateDto> faxNumberCreateDtoValidator, IMapper mapper)
        {
            _faxNumberManager = faxNumberManager;
            _faxNumberCreateDtoValidator = faxNumberCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _faxNumberManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new FaxNumberCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(FaxNumberCreateDto model)
        {
            var result = _faxNumberCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<FaxNumberCreateDto>(model);
                var createResponse = await _faxNumberManager.CreateAsync(dto);
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
            var response = await _faxNumberManager.GetByIdAsync<FaxNumberUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(FaxNumberUpdateDto dto)
        {
            var response = await _faxNumberManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
