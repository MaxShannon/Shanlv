using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shanlv.EfDbModels;
using Shanlv.IBll;

namespace Shanlv.DotNetCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public LoginController(ILogger<HomeController> logger, ShanlvDbContext shanlvDbContext, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserLogin(string userName, string password)
        {
            _userService.Login(userName, password);
            return Redirect(Url.Action("Index","User"));
        }

        [HttpGet]
        public IActionResult DriverLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DriverLogin(string userName, string password)
        {
            _userService.Login(userName, password);
            return Redirect(Url.Action("Index", "User"));
        }
    }
}