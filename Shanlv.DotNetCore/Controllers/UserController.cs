using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Shanlv.Bll;
using Shanlv.Dal;
using Shanlv.DomainModel.ViewModel;
using Shanlv.EfDbModels;
using Shanlv.IBll;
using Shanlv.IDal;

namespace Shanlv.DotNetCore.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShanlvDbContext _shanlvDbContext;
        private readonly IUserService _userService;

        public UserController(ILogger<HomeController> logger, ShanlvDbContext shanlvDbContext, IUserService userService)//
        {
            _logger = logger;
            _shanlvDbContext = shanlvDbContext;
            _userService = null; //userService;
            //var services = new ServiceCollection();
            //services.AddSingleton<IUserService, UserService>();
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public IActionResult Add(UserViewModel model)
        {
            // ceshi
            model.UserName = "newMax";
            _userService.Add(model);
            return Json("");
        }
    }
}