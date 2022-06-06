using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreWebApp.Controllers
{
    
    
        public class HomeController : Controller
        {

            public IActionResult Index()
            {

                return View();
            }

            public IActionResult Open()
            {
                return View(); // Triggered for Open click
            }
            public IActionResult Save()
            {
                return View(); // Triggered for Save click
            }
            public IActionResult Exit()
            {
                return View();   // Triggered for Exit Click
            }
        }
    
}
