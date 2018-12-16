using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bootstrap4demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace bootstrap4demo.Controllers
{
    public class InlineFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}