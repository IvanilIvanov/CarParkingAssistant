using Microsoft.AspNetCore.Mvc;

namespace CarParkingAssistant.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
