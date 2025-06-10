using DependencyInjectionDemo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//create builder for host
HostApplicationBuilder builder = Host.CreateApplicationBuilder();

//ask the builder to provide service registry
IServiceCollection serviceRegistry = builder.Services;

//register services
serviceRegistry.AddScoped<IManager, Manager>();
serviceRegistry.AddScoped<IDataAccess, DbDataAccess>();

//create the host
IHost host = builder.Build();

//ask the host for the container or provider
IServiceProvider provider = host.Services;

//asking for services (IManager type service)
IManager? manager = provider.GetRequiredService<IManager>();

//fetch data
string? data = manager?.FetchDataFromSource();
Console.WriteLine(data ?? "NA");
//run the host
host.Run();