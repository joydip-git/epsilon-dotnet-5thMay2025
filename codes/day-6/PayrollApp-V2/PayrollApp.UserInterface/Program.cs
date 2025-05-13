using PayrollApp.Entities;
using System.Data;

int count = GetCount();
Employee[] employees = CreateStorage(count);
SaveEmployee(employees);
PrintEmployeeSalary(employees);

static int GetCount()
{
    Console.Write("How many records: ");
    return int.Parse(Console.ReadLine());
}
static Employee CreateEmployee(int choice)
{
    Console.Write("\nenter id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("enter name: ");
    string name = Console.ReadLine();

    Console.Write("enter basic: ");
    decimal basic = decimal.Parse(Console.ReadLine());

    Console.Write("enter da: ");
    decimal da = decimal.Parse(Console.ReadLine());

    Console.Write("enter hra: ");
    decimal hra = decimal.Parse(Console.ReadLine());

    Employee employee;

    switch (choice)
    {
        case 1:
            Console.Write("enter incentive: ");
            decimal incentive = decimal.Parse(Console.ReadLine());
            employee = new Developer(id) { Name = name, BasicPay = basic, DaPay = da, HraPay = hra, IncentivePay = incentive };
            break;

        case 2:
            Console.Write("enter gratuity: ");
            decimal gratuity = decimal.Parse(Console.ReadLine());
            employee = new Hr(id) { Name = name, BasicPay = basic, DaPay = da, HraPay = hra, GratuityPay = gratuity };
            break;

        default:
            employee = null;
            break;
    }
    if (employee != null)
        employee.CalculateSalary();

    return employee;

}

static Employee[] CreateStorage(int size)
{
    Employee[] employees = new Employee[size];
    return employees;
}

static void PrintMenu() => Console.WriteLine("1. Developer\n2. Hr");

static int GetChoice()
{
    Console.Write("\nEnter choice for type of record[1/2/]: ");
    return int.Parse(Console.ReadLine());
}

static void SaveEmployee(Employee[] employees)
{
    for (int i = 0; i < employees.Length; i++)
    {
        PrintMenu();
        int choice = GetChoice();
        Employee employee = CreateEmployee(choice);
        employees[i] = employee;
    }
}

static void PrintEmployeeSalary(Employee[] employees)
{
    foreach (Employee item in employees)
    {
        Console.WriteLine($"Salary of {item.Name} is {item.TotalPay} ");
    }
}

