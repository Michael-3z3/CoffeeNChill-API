using CoffeeNChill.Functions.Interfaces;
using CoffeeNChill.Services;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

//Configure Azure Functions
//Configure Azure Functions with ASP.NET CoreHTTP integration
builder.ConfigureFunctionsWebApplication();

//register Services for Dependency injection
builder.Services.AddSingleton<ITableStorageService, TableStorageService>();
builder.Services.AddSingleton<IFileStorageService, FileStorageService>();

builder.Build().Run();
