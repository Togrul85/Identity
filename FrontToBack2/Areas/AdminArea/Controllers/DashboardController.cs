﻿using Microsoft.AspNetCore.Mvc;

namespace FrontToBack2.Areas.AdminArea.Controllers
{
    public class DashboardController : Controller
    {
        [Area("AdminArea")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
