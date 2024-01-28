using Microsoft.AspNetCore.Mvc;

namespace CarParkingAssistant.Areas.Admin.Controllers
{
    public class BookingController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
