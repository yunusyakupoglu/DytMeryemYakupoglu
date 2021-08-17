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
    public class AndulasyonController : Controller
    {
        private readonly IAndulasyonManager _andulasyonManager;
        private readonly IValidator<AndulasyonCreateDto> _andulasyonCreateDtoValidator;
        private readonly IValidator<AndulasyonUpdateDto> _andulasyonUpdateDtoValidator;
        private readonly IMapper _mapper;

        public AndulasyonController(IAndulasyonManager andulasyonManager, IValidator<AndulasyonCreateDto> andulasyonCreateDtoValidator, IValidator<AndulasyonUpdateDto> andulasyonUpdateDtoValidator, IMapper mapper)
        {
            _andulasyonManager = andulasyonManager;
            _andulasyonCreateDtoValidator = andulasyonCreateDtoValidator;
            _andulasyonUpdateDtoValidator = andulasyonUpdateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _andulasyonManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new AndulasyonCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AndulasyonCreateDto model)
        {
            var result = _andulasyonCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<AndulasyonCreateDto>(model);
                dto.ImagePath = _andulasyonManager.UploadImage(dto.FileDoc);
                var createResponse = await _andulasyonManager.CreateAsync(dto);
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
            var response = await _andulasyonManager.GetByIdAsync<AndulasyonUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AndulasyonUpdateDto dto)
        {
            var result = _andulasyonUpdateDtoValidator.Validate(dto);
            if (result.IsValid)
            {
                if (dto.FileDoc != null)
                {
                    _andulasyonManager.DeleteImage(dto.ImagePath);
                    dto.ImagePath = _andulasyonManager.UploadImage(dto.FileDoc);
                    var createResponse = await _andulasyonManager.UpdateAsync(dto);
                    return this.ResponseRedirectAction(createResponse, "Index");
                }
                else
                {
                    var createResponse = await _andulasyonManager.UpdateAsync(dto);
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
