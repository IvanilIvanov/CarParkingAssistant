using Microsoft.AspNetCore.Mvc;

namespace CarParkingAssistant.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
