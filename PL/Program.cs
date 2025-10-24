using DL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var conString = builder.Configuration.GetConnectionString("Prueba16octubre");
//Aqui es para agregar la conecxion de app seting
builder.Services.AddDbContext<Prueba16octubreContext>(options =>
    options.UseSqlServer(conString));
builder.Services.AddScoped<BL.Usuarios>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
