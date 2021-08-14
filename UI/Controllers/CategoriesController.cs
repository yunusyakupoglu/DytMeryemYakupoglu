using AutoMapper;
using BL.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Extensions;

namespace UI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IBlogManager _blogManager;
        private readonly IMapper _mapper;

        public CategoriesController(IBlogManager blogManager, IMapper mapper)
        {
            _blogManager = blogManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _blogManager.GetAllAsync();
            return this.ResponseView(response);
        }
    }
}
