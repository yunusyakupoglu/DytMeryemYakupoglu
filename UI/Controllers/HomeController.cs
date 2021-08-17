using BL.IServices;
using DAL;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBlogManager _blogManager;
        private readonly IAddressManager _addressManager;
        private readonly IMailManager _mailManager;
        private readonly ISocialMediaAccountManager _socialMediaAccountManager;
        private readonly INumberCategoryManager _numberCategoryManager;
        private readonly INumberManager _numberManager;
        private readonly IWorkingHourManager _workingHourManager;

        public HomeController(ApplicationDbContext context, IBlogManager blogManager, IAddressManager addressManager, 
            IMailManager mailManager, ISocialMediaAccountManager socialMediaAccountManager, 
            INumberCategoryManager numberCategoryManager, 
            INumberManager numberManager, IWorkingHourManager workingHourManager)
        {
            _context = context;
            _blogManager = blogManager;
            _addressManager = addressManager;
            _mailManager = mailManager;
            _socialMediaAccountManager = socialMediaAccountManager;
            _numberCategoryManager = numberCategoryManager;
            _numberManager = numberManager;
            _workingHourManager = workingHourManager;
        }

        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel();
            home.blogs = _blogManager.GetAllAsync().Result.Data;

            return View(home);
        }

        public IActionResult Blog()
        {
            HomeViewModel home = new HomeViewModel();
            home.blogs = _blogManager.GetAllAsync().Result.Data;
            return View(home);
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Andulasyon()
        {
            return View();
        }

        public IActionResult Contact()
        {
            HomeViewModel home = new HomeViewModel();
            home.addresses = _addressManager.GetAllAsync().Result.Data; // bakcaz
            home.mails = _mailManager.GetAllAsync().Result.Data;
            home.socialMediaAccounts = _socialMediaAccountManager.GetAllAsync().Result.Data;
            home.numberCategories = _numberCategoryManager.GetAllAsync().Result.Data;
            home.numbers = _numberManager.GetAllAsync().Result.Data;
            home.workingHours = _workingHourManager.GetAllAsync().Result.Data;
            return View(home);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult OnlineDiet()
        {
            return View();
        }

        public IActionResult Weakened()
        {
            return View();
        }

        public IActionResult Comments()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(ErrorDto errorDto)
        {
            return View(errorDto);
        }
    }
}
