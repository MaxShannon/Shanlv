using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shanlv.DomainModel.ViewModel;
using Shanlv.EfDbModels;
using Shanlv.IBll;

namespace Shanlv.DotNetCore.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShanlvDbContext _shanlvDbContext;
        private readonly IBaseService _baseService;

        public UserController(ILogger<HomeController> logger, ShanlvDbContext shanlvDbContext, IBaseService baseService)
        {
            _logger = logger;
            _shanlvDbContext = shanlvDbContext;
            _baseService = baseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserViewModel model)
        {
            // ceshi
            _baseService.Add();
            return Json("");
        }
    }
}