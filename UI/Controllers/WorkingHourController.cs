using AutoMapper;
using BL.IServices;
using BL.ValidationRules;
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
    public class WorkingHourController : Controller
    {
        private readonly IWorkingHourManager _workingHourManager;
        private readonly IValidator<WorkingHourCreateDto> _workingHourCreateDtoValidator;
        private readonly IMapper _mapper;

        public WorkingHourController(IWorkingHourManager workingHourManager, IValidator<WorkingHourCreateDto> workingHourCreateDtoValidator, IMapper mapper)
        {
            _workingHourManager = workingHourManager;
            _workingHourCreateDtoValidator = workingHourCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _workingHourManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new WorkingHourCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkingHourCreateDto model)
        {
            var result = _workingHourCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<WorkingHourCreateDto>(model);
                var createResponse = await _workingHourManager.CreateAsync(dto);
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
            var response = await _workingHourManager.GetByIdAsync<WorkingHourUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(WorkingHourUpdateDto dto)
        {
            var response = await _workingHourManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
