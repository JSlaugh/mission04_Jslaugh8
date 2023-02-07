using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using mission4_Joe_slaugh.Models;

namespace mission4_Joe_slaugh.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(GradeObjModel model)
        {
            return View();
        }
    }
}
