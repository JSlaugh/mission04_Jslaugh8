using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission4_Joe_slaugh.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }

    }
}
