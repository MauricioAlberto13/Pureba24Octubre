using DL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var conString = builder.Configuration.GetConnectionString("Prueba16octubre");
//Aqui es para agregar la conecxion de app seting
builder.Services.AddDbContext<Prueba16octubreContext>(options =>
    options.UseSqlServer(conString));


builder.Services.AddScoped<BL.Usuarios>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
