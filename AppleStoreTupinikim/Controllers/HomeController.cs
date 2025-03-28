﻿using AppleStoreTupinikim.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppleStoreTupinikim.Controllers
{
    public class HomeController : Controller
    {
        //3. Remover atributos e métodos herdados e que não serão sobrescritos
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
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