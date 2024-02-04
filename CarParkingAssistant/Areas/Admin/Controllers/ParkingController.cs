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

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddParkingViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                Parking parking = new();
                parking.Address = model.Address;
                parking.NumSlots = model.NumSlots;
                parking.Price = decimal.Parse( model.Price);
                await context.AddAsync(parking);
                await context.SaveChangesAsync();

            }
            Console.WriteLine(model.Address);
            return View();
        }
        
        public async Task<IActionResult> Delete(Guid id)
        {
            Parking parking = await context.Parkings.FirstOrDefaultAsync(p => p.Id == id);
            context.Parkings.Remove(parking);
            await context?.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            Parking parking = await context.Parkings.FirstOrDefaultAsync(p => p.Id == id);

            return View(parking);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Parking parking)
        {
            Console.WriteLine(parking.Address);
            Parking parking2 = await context.Parkings.FirstOrDefaultAsync(p => p.Id == parking.Id);
            parking2.Address = parking.Address;
            parking2.NumSlots = parking.NumSlots;
            parking2.Price = parking.Price;
            await context.SaveChangesAsync();

            return View(parking);
        }
    }
}
