//List<int> numbers = new List<int> { 1, 2, 3 };
using DelegateRevision;

List<int> numbers = [4, 1, 5, 2, 3, 6, 0, 8, 7, 9];

//static local function
LogicDel evenLogic = new LogicDel(IsEven);

//instance method of Calculation class
Calculation calculation = new Calculation();
LogicDel oddLogic = new LogicDel(calculation.IsOdd);

//static method of Calculation class
LogicDel greaterLogic = new LogicDel(Calculation.IsGreater);

Console.WriteLine("\t even numbers\t\n");
var evenNumbers = Filter(numbers, evenLogic);
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("\t odd numbers\t\n");
var oddNumbers = Filter(numbers, oddLogic);
foreach (var item in oddNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("\t numbers greater than 5 \t\n");
var greaterNumbers = Filter(numbers, greaterLogic);
foreach (var item in greaterNumbers)
{
    Console.WriteLine(item);
}

static List<int> Filter(List<int> input, LogicDel logic)
{
    List<int> result = [];
    foreach (var item in input)
    {
        bool isTrue = logic(item);
        if (isTrue)
            result.Add(item);
    }
    return result;
}

static bool IsEven(int value)
{
    return value % 2 == 0;
}

delegate bool LogicDel(int x);
