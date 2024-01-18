using CarParkingAssistant.Infrastructure.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingAssistant.Infrastructure
{
    public class CarParkingAssistantContext : DbContext
    {
        public CarParkingAssistantContext(DbContextOptions<CarParkingAssistantContext> options) : base(options)
        {

        }

        public DbSet<CarParkingAssistantUser> Users { get; set; }
    }
}
