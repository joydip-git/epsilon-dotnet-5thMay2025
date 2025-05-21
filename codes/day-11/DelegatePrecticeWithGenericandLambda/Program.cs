List<int> numbers = [1, 3, 2, 5, 4, 7, 8, 6, 0, 9];
LogicInvoker<int> evenDel = num => num % 2 == 0;
List<int> evenNumbers = Filter<int>(numbers, evenDel);
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n\n");
List<string> names = ["sunil", "anil", "karthik", "shruthi"];
LogicInvoker<string> nameHavingS = name => name.Contains('s');
List<string> namesHavingS = Filter<string>(names, nameHavingS);
foreach (var item in namesHavingS)
{
    Console.WriteLine(item);
}

static List<T> Filter<T>(List<T> input, LogicInvoker<T> invoker)
{
    List<T> result = [];
    foreach (var item in input)
    {
        bool isTrue = invoker(item);
        if (isTrue)
            result.Add(item);
    }
    return result;
}

delegate bool LogicInvoker<in T>(T num);
