using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ParkingMVC.Controllers
{
    public class UserController : Controller
    {
        // 
        // GET: /UserController/

        public ViewResult Index()
        {
            return View();
        }

        // 
        // GET: /UserController/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}