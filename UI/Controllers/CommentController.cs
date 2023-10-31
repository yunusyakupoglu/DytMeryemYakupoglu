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
    public class CommentController : Controller
    {
        private readonly ICommentManager _commentManager;
        private readonly IValidator<CommentCreateDto> _commentCreateDtoValidator;
        private readonly IMapper _mapper;

        public CommentController(ICommentManager commentManager, IValidator<CommentCreateDto> commentCreateDtoValidator, IMapper mapper)
        {
            _commentManager = commentManager;
            _commentCreateDtoValidator = commentCreateDtoValidator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _commentManager.GetAllAsync();
            return this.ResponseView(response);
        }

        public IActionResult Create()
        {
            var model = new CommentCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CommentCreateDto model)
        {
            var result = _commentCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<CommentCreateDto>(model);
                var createResponse = await _commentManager.CreateAsync(dto);
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
            var response = await _commentManager.GetByIdAsync<CommentUpdateDto>(id);
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CommentUpdateDto dto)
        {
            var response = await _commentManager.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
