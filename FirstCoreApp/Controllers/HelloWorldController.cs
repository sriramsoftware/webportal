using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace FirstCoreApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string Name, int Nos)
        {
            return HtmlEncoder.Default.Encode($"Welcome {Name}, Age is {Nos}");
        }
        public string Who(string Name, int Nos =1)
        {
            return HtmlEncoder.Default.Encode($"This is {Name}, Number is {Nos}");
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}