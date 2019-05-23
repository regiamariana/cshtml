using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mc_Bonalds.Models;

namespace mc_Bonalds.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Home";
            return View();
        }

        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
