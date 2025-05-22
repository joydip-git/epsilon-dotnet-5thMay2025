//source of data
List<int> numbers = [1, 2, 5, 3, 7, 8, 6, 4, 0, 9];
List<string> names = ["anil", "sunil", "joydip", "vinod"];

//1. method query syntax
numbers
    .OrderBy(x => x)
    .Where(x => x % 2 == 0)
    .Take(3)
    .ToList()
    .ForEach(x => Console.WriteLine(x));

names
    .OrderByDescending(name => name)
    .Where(name => name.Contains('n') || name.Contains('N'))
    .Take(2)
    .ToList()
    .ForEach(name => Console.WriteLine(name));

//2. query (operator) syntax
var query = from x in numbers
            orderby x ascending
            where x % 2 == 0
            select x;

query
    .Take(3)
    .ToList()
    .ForEach(x => Console.WriteLine(x));



/*
//1. sort the numbers in ascending order without mutating the original collection
//1. sort the names in ascending alphabetical order without mutating the original collection

Func<int, int> orderLogic = (x) => x;
var sortedNumbers = numbers.OrderBy(orderLogic);

Func<string, string> orderNameLogic = (name) => name;
var sortedNames = names.OrderBy(orderNameLogic);

//2. filter the even numbers from the sorted numbers
//2. filter the the sorted names by the names which have a letter 'n' in their name

Func<int, bool> isEvenLogic = num => num % 2 == 0;
var filteredNumbers = sortedNumbers.Where(isEvenLogic);

Func<string, bool> nameWithN = (name) => name.Contains('n') || name.Contains('N');
var filteredNames = names.Where(nameWithN);

//3. select the first 3 values from the filtered numbers. if 3 values are not present, then select as many are there.
//3. select the first 3 values from the filtered names. if 3 values are not present, then select as many are there.

var selectedNumbers = filteredNumbers.Take(3);
var selectedNames = filteredNames.Take(3);

//4. print the final numbers
//4. print the final names

Action<int> printNumber = (num) => Console.Write(num);
selectedNumbers.ToList().ForEach(printNumber);

Action<string> printName = name=> Console.WriteLine(name);
selectedNames.ToList().ForEach(printName);
*/