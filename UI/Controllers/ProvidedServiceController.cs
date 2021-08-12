using BL.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class ProvidedServiceController : Controller
    {
        private readonly IProvidedServiceManager _providedServiceManager;

        public ProvidedServiceController(IProvidedServiceManager providedServiceManager)
        {
            _providedServiceManager = providedServiceManager;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _providedServiceManager.GetAllAsync();
            return View();
        }
    }
}
