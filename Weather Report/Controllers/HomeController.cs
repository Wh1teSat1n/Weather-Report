using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Weather_Report.Models;

namespace Weather_Report.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;          
        }   
        
        public ActionResult Index()
        {
            return View();
        }
    }
}