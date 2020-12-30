using Countwiki.Models;
using Countwiki.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Countwiki.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWordCounter _wordCounter;

        public HomeController(IWordCounter wordCounter, ILogger<HomeController> logger)
        {
            _logger = logger;
            _wordCounter = wordCounter;
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
            try
            {
                // I have not validated here that it is a wikipedia page, currently it will work for all pages.
                string wikiContent = GetHtmlStringFromWikipedia(wikiCountViewModel.WikiPageURL);

                int count = _wordCounter.Count(wikiContent);

                wikiCountViewModel.WordCount = count;
            }
            catch (Exception exception)
            {
                TempData["ErrorMessage"] = $"Something went wrong counting the words at :{wikiCountViewModel.WikiPageURL}";
            }

            return RedirectToAction("Index", "Home", wikiCountViewModel);
            
        }

        /// <summary>
        /// Call out to the Wikipedia web site and gets the content.
        /// </summary>
        /// <param name="wikiPageURL">The URL of the page</param>
        /// <returns>The content as a string.</returns>
        private string GetHtmlStringFromWikipedia(string wikiPageURL)
        {
            // requires some try catch to catch when the site returns 404.
            Uri url = new Uri(wikiPageURL);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string html = client.DownloadString(url);
            return html;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
