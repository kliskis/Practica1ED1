using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld1.Controllers
{
    public class Student2 : Controller
    {
        public IActionResult Index()
        {
            return Ok("Test");
        }
    }
}
