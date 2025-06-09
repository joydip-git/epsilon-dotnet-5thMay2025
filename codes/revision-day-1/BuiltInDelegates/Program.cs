// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//public delegate bool Predicate<in T>(T obj);
Predicate<int> isEven = (int number) => number % 2 == 0;

//public delegate TResult Func<out TResult>();
//public delegate TResult Func<in T,out TResult>(T data);
Func<int, bool> isOdd = (int number) => number % 2 != 0;

//public delegate TResult Func<in T1,in T2, out TResult>(T1 data1, T2 data2);
Func<int, int, int> addLogic = (x, y) => x + y;
Func<int, int, bool> greaterLogic = (x, y) => x > y;

//public delegate TResult Func<in T1,in T2,..in T16, out TResult>(T1 data1, T2 data2,....,T16 data16);

//delegate void Action<in T1>(T1 data1);
Action<int> printDel = (x) => Console.WriteLine(x);

//delegate void Action<in T1,...,in T16>(T1 data1,...T16 data16);

List<int> numbers = [4, 1, 5, 2, 3, 6, 0, 8, 7, 9];
//Func<int, bool> isEvenLogic = x => x % 2 == 0;
//var result = numbers.Where(isEvenLogic);

//var evenNumbers = numbers.Where(x => x % 2 == 0);
//var orderedNumbers = evenNumbers.OrderBy(x => x);
//var orderedList = orderedNumbers.ToList();
//orderedList.ForEach(x => Console.WriteLine(x));

//LINQ: Method syntax
numbers
    .Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .ToList()
    .ForEach(x => Console.WriteLine(x));

//LINQ: Query syntax
(
    from x in numbers
    where x % 2 == 0
    orderby x ascending
    select x
 )
 .ToList()
 .ForEach(x => Console.WriteLine(x));

Console.WriteLine("original collection");
numbers.ForEach(x => Console.WriteLine(x));
//int value = 100;
//Print(value);
Print(100);
static void Print(int x)
{
    Console.WriteLine(x);
}



