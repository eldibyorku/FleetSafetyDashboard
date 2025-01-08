var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Add support for controllers

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Optional for better error handling during development
}

app.UseHttpsRedirection();

app.MapControllers(); // Map controller endpoints

app.Run();
