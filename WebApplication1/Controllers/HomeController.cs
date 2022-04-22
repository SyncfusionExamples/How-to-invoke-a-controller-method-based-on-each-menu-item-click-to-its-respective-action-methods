using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
           
            return View();
        }
        
        public IActionResult Open()
    {
            return View(); // Triggered for Save click
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
