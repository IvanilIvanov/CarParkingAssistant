using Microsoft.AspNetCore.Mvc;

namespace CarParkingAssistant.Controllers
{
    public class ParkingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }

    }
}
