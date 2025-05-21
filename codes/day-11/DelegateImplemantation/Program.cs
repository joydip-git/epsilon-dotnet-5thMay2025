List<int> numbers = [1, 4, 6, 2, 3, 8, 5, 9, 7, 0];


List<int> evenNumbers = Filter(numbers);
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}

//filter the list and returns another list containg JUST the even numbers
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



