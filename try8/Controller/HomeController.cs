using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using try8.Interface;

namespace try8.Controller
{
    public class HomeController : Controller
    {
        private readonly ILogModel logModel;

        public HomeController(ILogModel logModel)
        {
            this.logModel = logModel;
        }
        public IActionResult Index()
        {
            return View(logModel);
        }
    }
}
