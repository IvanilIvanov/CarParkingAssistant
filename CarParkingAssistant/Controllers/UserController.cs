using CarParkingAssistant.Core.Constants;
using CarParkingAssistant.Infrastructure.Data;
using CarParkingAssistant.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarParkingAssistant.Controllers
{
    public class UserController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<CarParkingAssistantUser> userManager;
        private readonly ApplicationDbContext context;

        public UserController(RoleManager<IdentityRole> roleManager,
            UserManager<CarParkingAssistantUser> userManager,
            ApplicationDbContext context)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ProducesResponseType<CarParkingAssistantUser>(StatusCodes.Status200OK)]
        public Task<IActionResult> Roles()
        {
            return CreateRoles();
        }

        public async Task<IActionResult> CreateRoles()
        {
            await roleManager.CreateAsync(new IdentityRole()
            {
                Name = UserConstants.Roles.Admin,
            });

            await roleManager.CreateAsync(new IdentityRole()
            {
                Name = UserConstants.Roles.Worker
            });

            await roleManager.CreateAsync(new IdentityRole()
            {
                Name = UserConstants.Roles.User
            });

            CarParkingAssistantUser? user = await context.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity!.Name);
            await userManager.AddToRoleAsync(user!, UserConstants.Roles.Admin);

            return Ok();
        }

    }
}
