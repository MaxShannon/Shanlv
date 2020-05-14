using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shanlv.DomainModel.ViewModel;
using Shanlv.IBll;

namespace Shanlv.DotNetCore.Controllers
{
    public class SubsidiaryController : BaseController<SubsidiaryViewModel>
    {
        private readonly ISubsidiaryService _subsidiaryService;

        public SubsidiaryController(ISubsidiaryService subsidiaryService)
        {
            _subsidiaryService = subsidiaryService;
        }

        public IActionResult Index(int pageIndex = 1, int pageSize = 10)
        {
            var subsidiaryList = _subsidiaryService.GetSubsidiaries(pageIndex, pageSize).ToList();
            return View(subsidiaryList);
        }

        public IActionResult Add()
        {
            SubsidiaryViewModel model = new SubsidiaryViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(SubsidiaryViewModel model)
        {
            if (ModelState.IsValid)
            {
                _subsidiaryService.Add(model);
            }

            return RedirectToAction(nameof(Index), new { });
        }

        //public IActionResult GetAllByPage(int pageIndex, int pageSize)
        //{
        //    var subsidiaryList = _subsidiaryService.GetAllByPage(pageIndex, pageSize).ToList();
        //    return View(subsidiaryList);
        //}
    }
}


