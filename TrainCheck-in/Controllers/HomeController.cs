using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrainCheck_in.Models;

namespace TrainCheck_in.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");

            db = context;

        }
       
        [HttpPost]
        public async Task<IActionResult> Create(Passenger passenger)
        {
            db.Passengers.Add(passenger);
            await db.SaveChangesAsync();
            _logger.LogInformation("Writing to the database");
            return RedirectToAction("Thanks");
        }
        public ViewResult Index()
        {
            _logger.LogInformation("A greeting is displayed");

            return View("Welcome");
        }
        [HttpGet]
        public ViewResult RegistrationForm()
        {
            _logger.LogInformation("The registration form is displayed");

            return View();
        }
        [HttpPost]
        public ViewResult RegistrationForm(Passenger passenger)
        {
            if (ModelState.IsValid) 
            {
            _logger.LogInformation("Data entered correctly");

                return View("Thanks");
            }
            else
            {
            _logger.LogWarning("Data entered incorrectly, re-entry required");

                return View();
            }  
        }
        public ViewResult Thanks()
        {
            _logger.LogInformation("The program has terminated");

            return View("Thanks");
        }
       
    }
}
