using DependencyInjectionDemo;
using Microsoft.Extensions.DependencyInjection;

//create a registry where services can be registered
IServiceCollection serviceRegistry = new ServiceCollection();

//register services
serviceRegistry.AddScoped<IManager, Manager>();

DataAccessChoices choiceOfDataAccess = DataAccessChoices.FileData;

switch (choiceOfDataAccess)
{
    case DataAccessChoices.FileData:

        serviceRegistry.AddScoped<IDataAccess, FileDataAccess>();

        break;

    case DataAccessChoices.DatabaseData:

        serviceRegistry.AddScoped<IDataAccess, DbDataAccess>();
        //ServiceDescriptor descriptorOfDbDataAccess
        //    = new ServiceDescriptor(
        //        serviceType: typeof(IDataAccess),
        //        implementationType: typeof(DbDataAccess),
        //        lifetime: ServiceLifetime.Scoped
        //        );

        //serviceRegistry.Add(descriptorOfDbDataAccess);

        break;

    default:
        break;
}

//create a provider (container) for the registered services
IServiceProvider provider = serviceRegistry.BuildServiceProvider();

//ask to create Manager instance
IManager? manager = provider.GetRequiredService<IManager>();
string? data = manager?.FetchDataFromSource();
Console.WriteLine(data ?? "NA");



