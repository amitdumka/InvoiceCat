using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceCatWebApp.Controllers
{
    public class Panel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
