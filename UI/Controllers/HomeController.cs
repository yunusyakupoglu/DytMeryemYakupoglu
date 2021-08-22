using AutoMapper;
using BL.IServices;
using DAL;
using DTOs;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Extensions;
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
        private readonly IWorkingHourManager _workingHourManager;
        private readonly ICommentManager _commentManager;
        private readonly IOnlineDietManager _onlineDietManager;
        private readonly IAboutUsManager _aboutUsManager;
        private readonly IFaqManager _faqManager;
        private readonly IOnlineDietFaqManager _onlineDietFaqManager;
        private readonly IOnlineDietInformationListManager _onlineDietInformationListManager;
        private readonly IWeakenedManager _weakenedManager;
        private readonly IPhoneNumberManager _phoneNumberManager;
        private readonly IFaxNumberManager _faxNumberManager;
        private readonly IProvidedServiceManager _providedServiceManager;

        private readonly IValidator<CommentCreateDto> _commentCreateDtoValidator;
        private readonly IValidator<OnlineDietCreateDto> _onlineDietCreateDtoValidator;
        private readonly IMapper _mapper;

        public HomeController(ApplicationDbContext context, IBlogManager blogManager,
            IAddressManager addressManager, IMailManager mailManager,
            ISocialMediaAccountManager socialMediaAccountManager, IWorkingHourManager workingHourManager,
            ICommentManager commentManager, IValidator<CommentCreateDto> commentCreateDtoValidator,
            IMapper mapper, IValidator<OnlineDietCreateDto> onlineDietCreateDtoValidator, IOnlineDietManager onlineDietManager,
            IAboutUsManager aboutUsManager, IFaqManager faqManager, IOnlineDietFaqManager onlineDietFaqManager,
            IOnlineDietInformationListManager onlineDietInformationListManager, IWeakenedManager weakenedManager, IFaxNumberManager faxNumberManager, IPhoneNumberManager phoneNumberManager, IProvidedServiceManager providedServiceManager)
        {
            _context = context;
            _blogManager = blogManager;
            _addressManager = addressManager;
            _mailManager = mailManager;
            _socialMediaAccountManager = socialMediaAccountManager;
            _workingHourManager = workingHourManager;
            _commentManager = commentManager;
            _commentCreateDtoValidator = commentCreateDtoValidator;
            _mapper = mapper;
            _onlineDietCreateDtoValidator = onlineDietCreateDtoValidator;
            _onlineDietManager = onlineDietManager;
            _aboutUsManager = aboutUsManager;
            _faqManager = faqManager;
            _onlineDietFaqManager = onlineDietFaqManager;
            _onlineDietInformationListManager = onlineDietInformationListManager;
            _weakenedManager = weakenedManager;
            _faxNumberManager = faxNumberManager;
            _phoneNumberManager = phoneNumberManager;
            _providedServiceManager = providedServiceManager;
        }

        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel();
            home.blogs = _blogManager.GetAllAsync().Result.Data;
            home.Comments = _commentManager.GetAllAsync().Result.Data;
            home.providedServices = _providedServiceManager.GetAllAsync().Result.Data;
            return View(home);
        }

        public IActionResult Blog()
        {
            HomeViewModel home = new HomeViewModel();
            home.blogs = _blogManager.GetAllAsync().Result.Data;
            return View(home);
        }

        public async Task<IActionResult> Details(int id)
        {
            var response = await _blogManager.GetByIdAsync<BlogListDto>(id);
            return View(response.Data);
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
            home.workingHours = _workingHourManager.GetAllAsync().Result.Data;
            home.FaxNumbers = _faxNumberManager.GetAllAsync().Result.Data;
            home.PhoneNumbers = _phoneNumberManager.GetAllAsync().Result.Data;
            return View(home);
        }

        public IActionResult AboutUs()
        {
            HomeViewModel home = new HomeViewModel();
            home.AboutUsList = _aboutUsManager.GetAllAsync().Result.Data;
            home.Faqs = _faqManager.GetAllAsync().Result.Data;
            return View(home);
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult OnlineDiet()
        {
            HomeViewModel home = new HomeViewModel();
            home.OnlineDietFaqs = _onlineDietFaqManager.GetAllAsync().Result.Data;
            home.OnlineDietInformationLists = _onlineDietInformationListManager.GetAllAsync().Result.Data;
            home.WeakenedLists = _weakenedManager.GetAllAsync().Result.Data;
            return View(home);
        }

        public IActionResult OnlineDietRecord()
        {
            var model = new OnlineDietCreateDto();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> OnlineDietRecord(OnlineDietCreateDto model)
        {
            var result = _onlineDietCreateDtoValidator.Validate(model);
            if (result.IsValid)
            {
                var dto = _mapper.Map<OnlineDietCreateDto>(model);
                var createResponse = await _onlineDietManager.CreateAsync(dto);
                return this.ResponseRedirectAction(createResponse, "Index");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return View(model);
        }

        public IActionResult Weakened()
        {
            HomeViewModel home = new HomeViewModel();
            home.WeakenedLists = _weakenedManager.GetAllAsync().Result.Data;
            return View(home);
        }

        public IActionResult Comments()
        {
            HomeViewModel home = new HomeViewModel();
            home.Comments = _commentManager.GetAllAsync().Result.Data;
            return View(home);
        }

        public IActionResult CreateComments()
        {
            var model = new CommentCreateDto();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComments(CommentCreateDto model)
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
