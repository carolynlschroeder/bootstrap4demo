﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bootstrap4demo.Controllers
{
    public class GridController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}