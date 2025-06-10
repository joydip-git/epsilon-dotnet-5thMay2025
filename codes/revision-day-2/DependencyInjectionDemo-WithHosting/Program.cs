using DependencyInjectionDemo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//create builder for host
HostApplicationBuilder builder = Host.CreateApplicationBuilder();

//ask the builder to provide service registry
IServiceCollection serviceRegistry = builder.Services;

//register services
serviceRegistry.AddScoped<IManager, Manager>();
serviceRegistry.AddScoped<IDataAccess, DbDataAccess>();

//configuration service is auto-registered
//serviceRegistry.AddSingleton<IConfiguration,ConfigurationManager>();

//ask the builder to provide configuraion provider
ConfigurationManager configManager = builder.Configuration;
configManager.AddJsonFile("appSettings.json", true, true);

//create the host
IHost host = builder.Build();

//ask the host for the container or provider
IServiceProvider provider = host.Services;

//asking for services (IManager type service)
IManager? manager = provider.GetRequiredService<IManager>();

//fetch data
string? data = manager?.FetchDataFromSource();
Console.WriteLine(data ?? "NA");

//get the configuration povider service object
IConfiguration? configProvider = provider.GetRequiredService<IConfiguration>();

//read configuration data
string? conStr = configProvider.GetConnectionString("EpsilonDbConStr");
Console.WriteLine(conStr ?? "NA");

string? value = configProvider.GetSection("Keys").GetValue<string>("key1");
Console.WriteLine(value ?? "NA");

//ask for Logging service object [register your logger service first]
//ILogger loggerProvider = provider.GetRequiredService<ILogger>();

//loggerProvider.LogInformation(conStr ?? "NA");
//loggerProvider.LogInformation(value ?? "NA");

//run the host
host.Run();