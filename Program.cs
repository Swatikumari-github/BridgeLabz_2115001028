using BusinessLayer.Service;
using RepositoryLayer.Service;
using ModelLayer.DTO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<RegisterHelloRL>();
builder.Services.AddScoped<RegisterHelloBL>();
builder.Services.AddScoped<LoginDTO>();
builder.Services.AddScoped<RegisterDTO>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();