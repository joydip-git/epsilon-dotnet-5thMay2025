/*
//TaskDel<string> printDel = new TaskDel<string>(Show);
TaskDel<string> printDel = Show;

//Lambda expression is the syntax to write an anonymous method.
//before lambda operator (=>) mention the list of arguments and
//after the lambda operator, create the method body either using expression body syntax or traditional way (using -> { //code })
TaskDel<int> printNumberDel = (num) => Console.WriteLine(num);
*/
Action<string> printDel = Show;
printDel("joydip");

Predicate<int> isEven = (num) => num % 2 == 0;

Func<int, bool> isOdd = (num) => num % 2 != 0;
Func<int, int, bool> isGreater = (x, y) => x > y;

//if return value is 0  -> x is equal to y
//if return value is <0 -> x is less than y
//if return value is >0 -> x is greater than y
Func<int, int, int> compare = (x, y) => x - y;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
List<int> result = Filter(numbers, isEven);

//Action<int> printNumber = (num) => Console.WriteLine(num);
//result.ForEach(printNumber);
result.ForEach(num => Console.WriteLine(num));

static void Show(string name) => Console.WriteLine(name);

//delegate void TaskDel<in T>(T input);
//delegate bool LogicInvoker<in T>(T t);
static List<T> Filter<T>(List<T> input, Predicate<T> logic)
{
    var list = new List<T>();
    foreach (var item in input)
    {
        bool isTrue = logic(item);
        if (isTrue)
            list.Add(item);
    }
    return list;
}