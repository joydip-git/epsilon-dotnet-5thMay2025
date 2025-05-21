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

Console.WriteLine("\nall numbers greater than 5\n");
//bool IsGreaterThanFive(int num) {return num>5;}
//anonymous method => (int num) { return num>5;}
//anonymous method signature should match that of the delegate
//if a delegate reference variable refers an anonymous method, it is known as anonymous delegate (delegate has proper name, but it refers an anonymous method) => anonymous delegate
LogicInvoker greaterLogic = delegate (int num)
{
    //code should be such that it returns boolean
    return num > 5;
};
List<int> greaterNumbers = Filter(numbers, greaterLogic);
foreach (var item in greaterNumbers)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nnumbers less than 5\n");

//Lambda expression (using expression body syntax) to write anonymous method
//Lambda operator (=>)
//LogicInvoker lessThanLogic = (int num) =>
//{
//    return (num < 5);
//};

//LogicInvoker lessThanLogic = (int num) => num < 5;

//no need to mention the data type even, since the data type will be inferred
LogicInvoker lessThanLogic = (num) => num < 5;
List<int> lesserNumbers = Filter(numbers, lessThanLogic);
foreach (var item in lesserNumbers)
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