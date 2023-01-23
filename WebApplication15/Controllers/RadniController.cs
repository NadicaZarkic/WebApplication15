using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication15.Controllers
{
    public class RadniController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
