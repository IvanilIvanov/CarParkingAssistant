using Microsoft.AspNetCore.Mvc;

namespace CarParkingAssistant.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }
    }
}
