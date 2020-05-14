using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shanlv.Bll;

namespace Shanlv.DotNetCore.Controllers
{
    public class BaseController<T> : Controller
    {
        //public BaseService<T> Service { get; set; }

        //[HttpPost]
        //public IActionResult Add(T viewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //viewModel.UserName = "newMax";

        //        Service.Add(model);
        //    }

        //    return RedirectToAction(nameof(Index), new { });
        //}

        //public IActionResult GetAllByPage(int pageIndex, int pageSize)
        //{
        //    return DT_UserDAL.GetUser(int sex, int age).ToList();
        //}
    }
}