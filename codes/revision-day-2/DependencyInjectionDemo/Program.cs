// See https://aka.ms/new-console-template for more information
using DependencyInjectionDemo;

Console.WriteLine("Hello, World!");

//Manager manager = new();
//string data = manager.FetchDataFromSource(DataAccessChoices.FileData);

Console.WriteLine("--menu---");
Console.WriteLine("1. from file\n2. from database");

Console.Write("\nenter choice[1/2]: ");
int choice = int.Parse(Console.ReadLine() ?? "1");

DataAccessChoices accessChoice = DataAccessChoices.FileData;
if (choice == 1)
    accessChoice = DataAccessChoices.FileData;
else if (choice == 2)
    accessChoice = DataAccessChoices.DatabaseData;

IDataAccess? dataAccess;
switch (accessChoice)
{
    case DataAccessChoices.FileData:
        dataAccess = new FileDataAccess();
        break;

    case DataAccessChoices.DatabaseData:
        dataAccess = new DbDataAccess();
        break;

    default:
        dataAccess = null;
        break;
}

if (dataAccess != null)
{
    Manager manager = new Manager(dataAccess);
    string data = manager.FetchDataFromSource();
    Console.WriteLine(data);
}
