using Microsoft.EntityFrameworkCore;
using FleetSafetyBackend.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Add support for controllers


builder.Services.AddDbContext<FleetSafetyDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Optional for better error handling during development
}

app.UseHttpsRedirection();

app.MapControllers(); // Map controller endpoints

app.Run();
