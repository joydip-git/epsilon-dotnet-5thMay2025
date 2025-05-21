// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
CalculationDel cdAdd = (m, n) => m + n;
TaskDel printTask = (name) => Console.WriteLine(name);

PrintValue(printTask, "joydip");

static void PrintValue(TaskDel task, string data)
{
    task(data);
}

//declare a delegate which can be used to invoke any method which accepts ONLY one argument of type "string" and returns nothing (void)
delegate void TaskDel(string value);

//declare a delegate which can be used to invoke any method which accepts ONLY two arguments of type "int" and "int" and returns "int"
delegate int CalculationDel(int a, int b);
