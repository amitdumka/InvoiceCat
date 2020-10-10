using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceCatWebApp.Data;
using InvoiceCatWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InvoiceCatWebApp.Controllers
{
    public class Panel : Controller
    {

        private readonly ILogger<Panel> _logger;
        private readonly ApplicationDbContext _context;

        public Panel(ApplicationDbContext context, ILogger<Panel> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clients()
        {
            var clients = _context.Clients;

            return View(clients);
        }
    }
}
