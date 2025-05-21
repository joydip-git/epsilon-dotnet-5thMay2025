using DelegateImplemantation;

List<int> numbers = [1, 4, 6, 2, 3, 8, 5, 9, 7, 0];

Console.WriteLine("filtering even numbers\n");
//Version-1:
//List<int> evenNumbers = Filter(numbers);

//Version-2:
Logic logic = new Logic();
LogicInvoker evenLogic = new LogicInvoker(logic.IsEven);
List<int> evenNumbers = Filter(numbers, evenLogic);
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("\nfiltering odd numbers\n");
LogicInvoker oddLogic = new LogicInvoker(Logic.IsOdd);
List<int> oddNumbers = Filter(numbers, oddLogic);
foreach (var item in oddNumbers)
{
    Console.WriteLine(item);
}

//filter the list and returns another list containg JUST the even numbers

//Version-2:
static List<int> Filter(List<int> input, LogicInvoker invoker)
{
    List<int> output = [];
    foreach (var item in input)
    {
        bool isTrue = invoker(item);
        if (isTrue)
            output.Add(item);
    }
    return output;
}

//Version-1:
/*
static List<int> Filter(List<int> input)
{
    List<int> output = [];
    foreach (var item in input)
    {
        if (item % 2 == 0)
            output.Add(item);
    }
    return output;
}
*/