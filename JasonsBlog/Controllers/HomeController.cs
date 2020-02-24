using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JasonsBlog.Controllers
{
    public class HomeController :  Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
