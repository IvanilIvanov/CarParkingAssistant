using Microsoft.AspNetCore.Mvc;

namespace CarParkingAssistant.Areas.Admin.Controllers
{
    public class ParkingController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
