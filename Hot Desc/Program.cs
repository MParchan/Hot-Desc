using Hot_Desc.DAL.Repositories;
using Hot_Desc.DAL.Repositories.Interfaces;
using Hot_Desc.DAL.Services;
using Hot_Desc.DAL.Services.Interfaces;
using Hot_Desc.DAL.UnitOfWork;
using Hot_Desc.Data;
using Hot_Desc.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HotDescDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotDescConnection")));


builder.Services.AddDatabaseDeveloperPageExceptionFilter();
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IWorkplaceRepository, WorkplaceRepository>();
builder.Services.AddTransient<IReservationRepository, ReservationRepository>();
builder.Services.AddTransient<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddTransient<IEquipmentForWorkplaceRepository, EquipmentForWorkplaceRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IHotDescService, HotDescService>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IReservationService, ReservationService>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<HotDescDbContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
