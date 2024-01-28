using CarParkingAssistant.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarParkingAssistant.Areas.Admin.Controllers
{
    [Authorize(Roles = UserConstants.Roles.Admin)]
    [Area("Admin")]
    public class BaseController : Controller
    {
    }
}
