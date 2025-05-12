using PayrollApp.Entities;

//Developer developer = new(100);
//developer.Name = "Joydip";
//developer.BasicPay = 1000;
//developer.DaPay = 1000;
//developer.HraPay = 1000;
//developer.IncentivePay = 1000;

//object-initializer
Developer developer = new(100) { Name = "Joydip", BasicPay = 1000, DaPay = 1000, HraPay = 1000, IncentivePay = 1000 };

//array initializer
//int[] numbers = new int[] { 1, 2, 3, 4, 5 };

developer.CalculateSalary();
Console.WriteLine($"A {nameof(Developer)} named: {developer.Name} with Id: {developer.Id} from the company: {Developer.COMPANY_NAME} and from department {Developer.DepartmentName} got salary of {developer.TotalPay}");

//Console.WriteLine(Math.PI);

