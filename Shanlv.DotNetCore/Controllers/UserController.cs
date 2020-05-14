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
        private readonly IUserService _userService;

        public UserController(ILogger<HomeController> logger, ShanlvDbContext shanlvDbContext, IUserService userService)
        {
            _logger = logger;
            _shanlvDbContext = shanlvDbContext;
            _userService = userService;
        }

        public IActionResult Index()
        {
            _userService.GetAllUser();
            return View(_userService.GetAllUser());
        }



        //[HttpPost]
        public IActionResult Add(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.UserName = "newMax";
                _userService.Add(model);
            }

            return RedirectToAction(nameof(Index), new { });
        }
    }
}