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
    public class WeakenedController : Controller
    {
        private readonly IWeakenedManager _weakenedManager;
        private readonly IValidator<WeakenedCreateDto> _weakenedCreateDtoValidator;
        private readonly IValidator<WeakenedUpdateDto> _weakenedUpdateDtoValidator;
        private readonly IMapper _mapper;

        public WeakenedController(IWeakenedManager weakenedManager, IValidator<WeakenedCreateDto> weakenedCreateDtoValidator, IValidator<WeakenedUpdateDto> weakenedUpdateDtoValidator, IMapper mapper)
        {
            _weakenedManager = weakenedManager;
            _weakenedCreateDtoValidator = weakenedCreateDtoValidator;
            _weakenedUpdateDtoValidator = weakenedUpdateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _weakenedManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new WeakenedCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(WeakenedCreateDto model)
        {
            var result = _weakenedCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<WeakenedCreateDto>(model);
                dto.FilePath = _weakenedManager.UploadImage(dto.FileDoc);
                var createResponse = await _weakenedManager.CreateAsync(dto);
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
            var response = await _weakenedManager.GetByIdAsync<WeakenedUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(WeakenedUpdateDto dto)
        {
            var result = _weakenedUpdateDtoValidator.Validate(dto);
            if (result.IsValid)
            {
                if (dto.FileDoc != null)
                {
                    _weakenedManager.DeleteImage(dto.FilePath);
                    dto.FilePath = _weakenedManager.UploadImage(dto.FileDoc);
                    var createResponse = await _weakenedManager.UpdateAsync(dto);
                    return this.ResponseRedirectAction(createResponse, "Index");
                }
                else
                {
                    var createResponse = await _weakenedManager.UpdateAsync(dto);
                    return this.ResponseRedirectAction(createResponse, "Index");
                }

            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return View(dto);
        }
    }
}
