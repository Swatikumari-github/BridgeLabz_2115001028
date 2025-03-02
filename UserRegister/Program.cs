

//using BusinessLayer.Service;
//using BusinessLayer.Interface;
//using RepositoryLayer.Service;
//using ModelLayer.DTO;
//using Microsoft.EntityFrameworkCore;
//using RepositoryLayer.Context;
//using NLog;
//using NLog.Web;
//using System.Reflection.Metadata;
//using RepositoryLayer.Interface;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;


//var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

//try
//{
//    logger.Info("Application Starting...");

//    var builder = WebApplication.CreateBuilder(args);

//    // NLog Setup
//    builder.Logging.ClearProviders();
//    builder.Host.UseNLog();

//    // Add services to the container.
//    builder.Services.AddControllers();

//    // Dependency Injection
//    builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();
//    builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();
//    builder.Services.AddScoped(typeof(ILoggerSer<>), typeof(LoggerService<>));
//    builder.Services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>)); // Logger Service

//    // Database Connection
//    var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
//    builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));

//    // Add Swagger
//    builder.Services.AddEndpointsApiExplorer();
//    builder.Services.AddSwaggerGen();

//    var app = builder.Build();

//    // Enable Swagger
//    app.UseSwagger();
//    app.UseSwaggerUI();

//    // Configure Middleware
//    app.UseHttpsRedirection();
//    app.UseAuthorization();
//    app.MapControllers();
//    app.Run();
//}
//catch (Exception ex)
//{
//    logger.Error(ex, "Application stopped because of an exception.");
//    throw;
//}
//finally
//{
//    LogManager.Shutdown();
//}
using BusinessLayer.Service;
using BusinessLayer.Interface;
using RepositoryLevel.Interface;
using RepositoryLayer.Service;
using ModelLayer.DTO;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using NLog;
using NLog.Web;
using System.Reflection.Metadata;

var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

try
{
    logger.Info("Application Starting...");

    var builder = WebApplication.CreateBuilder(args);

    // NLog Setup
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    // Add services to the container.
    builder.Services.AddControllers();

    // Dependency Injection
    builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();
    builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();
    builder.Services.AddScoped(typeof(ILoggerSer<>), typeof(LoggerSer<>));
    builder.Services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>)); // Logger Service

    // Database Connection
    var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
    builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));

    // Add Swagger
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Enable Swagger
    app.UseSwagger();
    app.UseSwaggerUI();

    // Configure Middleware
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application stopped because of an exception.");
    throw;
}
finally
{
    LogManager.Shutdown();
}
