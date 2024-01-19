using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CarParkingAssistant.Data;
using CarParkingAssistant.Areas.Identity.Data.Entities;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CarParkingAssistantContextConnection") ?? throw new InvalidOperationException("Connection string 'CarParkingAssistantContextConnection' not found.");

builder.Services.AddDbContext<CarParkingAssistantContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CarParkingAssistantUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<CarParkingAssistantContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
