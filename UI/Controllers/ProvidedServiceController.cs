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
    public class ProvidedServiceController : Controller
    {
        private readonly IProvidedServiceManager _providedServiceManager;
        private readonly IMapper _mapper;

        public ProvidedServiceController(IProvidedServiceManager providedServiceManager, IMapper mapper)
        {
            _providedServiceManager = providedServiceManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _providedServiceManager.GetAllAsync();
            return this.ResponseView(response);
        }

        //public async Task<IActionResult> Create()
        //{
        //    return View();
        //}
    }
}
