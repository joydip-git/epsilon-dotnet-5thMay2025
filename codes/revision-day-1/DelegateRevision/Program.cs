//List<int> numbers = new List<int> { 1, 2, 3 };
using DelegateRevision;

List<int> numbers = [4, 1, 5, 2, 3, 6, 0, 8, 7, 9];

//static local function
//LogicDel<int> evenLogic = new LogicDel<int>(IsEven);
//LogicDel<int> evenLogic =IsEven;
Predicate<int> evenLogic = IsEven;

//instance method of Calculation class
Calculation calculation = new Calculation();
//LogicDel<int> oddLogic = new LogicDel<int>(calculation.IsOdd);
//LogicDel<int> oddLogic =calculation.IsOdd;
Predicate<int> oddLogic = calculation.IsOdd;

//static method of Calculation class
//LogicDel<int> greaterLogic = new LogicDel<int>(Calculation.IsGreater);
//LogicDel<int> greaterLogic = Calculation.IsGreater;
Predicate<int> greaterLogic = Calculation.IsGreater;

Console.WriteLine("\t even numbers\t\n");
var evenNumbers = Filter<int>(numbers, evenLogic);
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("\t odd numbers\t\n");
var oddNumbers = Filter<int>(numbers, oddLogic);
foreach (var item in oddNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("\t numbers greater than 5 \t\n");
var greaterNumbers = Filter<int>(numbers, greaterLogic);
foreach (var item in greaterNumbers)
{
    Console.WriteLine(item);
}

List<string> names = ["anil", "sunil", "joydip"];
//anonymous method
//1.
//LogicDel<string> filterByN = new LogicDel<string>(
//   delegate (string name)
//    {
//        return name.Contains('n');
//    }
//    );
//2.
//LogicDel<string> filterByN = delegate (string name)
//{
//    return name.Contains('n');
//};

//anonymous method using lambda expression
//LogicDel<string> filterByN = (string name) => name.Contains('n');
//LogicDel<string> filterByN = (name) => name.Contains('n');
Predicate<string> filterByN = (name) => name.Contains('n');
var namesWithN = Filter<string>(names,filterByN);

Console.WriteLine("\tnamesWithN\t\n");
foreach (var item in namesWithN)
{
    Console.WriteLine(item);
}

//static List<int> Filter(List<int> input, LogicDel logic)
//generic method
//static List<TInput> Filter<TInput>(List<TInput> input, LogicDel<TInput> logic)
static List<TInput> Filter<TInput>(List<TInput> input, Predicate<TInput> logic)
{
    List<TInput> result = [];
    foreach (var item in input)
    {
        //bool isTrue = logic(item);
        //if (isTrue)
        if (logic(item))
            result.Add(item);
    }
    return result;
}

static bool IsEven(int value)
{
    return value % 2 == 0;
}

//delegate bool LogicDel(int x);

//generic delegate
//T -> generic type parameter
//delegate bool LogicDel<in T>(T value);

//delegate bool Predicate<in T>(T value);
