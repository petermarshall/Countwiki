using Countwiki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Countwiki.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(WikiCountViewModel wikiCountViewModel)
        {
            if(wikiCountViewModel == null)
            {
                wikiCountViewModel = new WikiCountViewModel();
            }
            return View(wikiCountViewModel);
        }
        [HttpPost]
        public IActionResult Count(WikiCountViewModel wikiCountViewModel)
        {
            return RedirectToAction("Index", "Home", wikiCountViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
