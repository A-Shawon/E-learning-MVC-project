﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Student_Portal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Portal.Controllers
{
    public class HomeController : Controller
    {
        public void OnGet()
        { }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CGP_calculator()
        {
            return View();
        }
        public IActionResult AdmitCard()
        {
            return View();
        }
        public IActionResult Attendenence()
        {
            return View();
        }
       
        public IActionResult Login()
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
