using Microsoft.AspNetCore.Mvc;

namespace IskoAlert_WebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: Admin/ManageIncidents
        public IActionResult ManageIncidents()
        {
            return View();
        }

        public IActionResult ReviewIncident()
        {
            return View();
        }

        public IActionResult ManageLostAndFound()
        {
            return View();
        }
    }
}
