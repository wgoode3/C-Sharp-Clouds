using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clouds.Models;

namespace Clouds.Controllers
{
    public class HomeController : Controller
    {

        public static List<string> clouds = new List<string>(){};

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ListOfClouds = clouds;
            return View();
        }

        [Route("new")]
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create(Cloud c)
        {
            if(ModelState.IsValid)
            {
                clouds.Add($"The altitude is: {c.altitude} and type is: {c.type}");
                return Redirect("/");
            }
            else
            {
                return View("New");
            }
        }

    }
}
