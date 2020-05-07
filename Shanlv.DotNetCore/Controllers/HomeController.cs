using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shanlv.DotNetCore.Models;
using Shanlv.EfDbModels;
using System.Diagnostics;
using System.Linq;
using Shanlv.DomainModel;

namespace Shanlv.DotNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShanlvDbContext _shanlvDbContext;

        public HomeController(ILogger<HomeController> logger, ShanlvDbContext shanlvDbContext)
        {
            _logger = logger;
            _shanlvDbContext = shanlvDbContext;
        }

        public IActionResult Index()
        {
            var t1 = _shanlvDbContext.Users;
            User user = new User();

            user.UserName = "max";
            //[IsDelete] bit NOT NULL,
            //[InspectId] int NOT NULL,
            //[InspectTime] datetime2 NOT NULL,
            //[UserName] nvarchar(max) NULL,
            _shanlvDbContext.Users.Add(user);
            _shanlvDbContext.SaveChanges();
            var t2 = _shanlvDbContext.Users.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
