using CarParkingAssistant.Core.Models;
using CarParkingAssistant.Infrastructure.Data;
using CarParkingAssistant.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarParkingAssistant.Areas.Admin.Controllers
{
    public class ParkingController : BaseController
    {
        private ApplicationDbContext context;
        public ParkingController(ApplicationDbContext context)
        {
            this.context = context; 
        }
        public async Task<IActionResult> Index()
        {
            ICollection<Parking> parkings = await context.Parkings.Include(p => p.Worker).ToListAsync();
            AdminParkingViewModel adminParkingViewModel = new AdminParkingViewModel();
            adminParkingViewModel.Parkings = parkings;
            return View(adminParkingViewModel);
        }
    }
}
