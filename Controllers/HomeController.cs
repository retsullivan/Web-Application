using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MasterDbContext _context;

        public HomeController(ILogger<HomeController> logger, Data.MasterDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            var fullName = this._context.People.Where(e => e.MiddleName == "Nash")
                                               .OrderBy(e =>e.FirstName)
                                               .Select(e => e.FirstName + " " + e.MiddleName + " " + e.LastName )
                                               .FirstOrDefault();
            
            return View(new HelloWorldModel()
            {
                message = "Hello, " + fullName
            }); ;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
