using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyApp.Filters;
using MyApp.Models;

namespace MyApp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return Ok("Done!");
        }

        [HttpGet]
        [Route("home/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateModel]
        [Route("home/create")]
        public IActionResult Create(Product model)
        {
            return View();
        }




    }
}