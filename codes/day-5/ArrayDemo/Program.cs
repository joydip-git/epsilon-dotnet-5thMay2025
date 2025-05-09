/*
int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"enter value at numbers[{i}]: ");
    numbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\n\n");

//Array class's static methods
Array.Sort(numbers);
//Array.Reverse(numbers);

//Array class's non-static methods
int[] copyArray = new int[numbers.Length];
numbers.CopyTo(copyArray, 0);

//read-only loop
//during iteration using foreach loop the data structure should not be modified (no new iten should be added or deleted, ONLY can be updated)
int index = 0;
foreach (int item in numbers)
{
    Console.WriteLine($"value from numbers[{index}]: {item}");
    index++;
}
*/
int[,] twoDimArray = new int[3, 3];

//total length:
//twoDimArray.Length; => 6

//row -> 1st dimension => index: 0
//colum -> 2nd dimension => index: 1

//Console.WriteLine($"no of rows: {twoDimArray.GetLength(0)}");
//Console.WriteLine($"no of columns: {twoDimArray.GetLength(1)}");

for (int rowIndex = 0; rowIndex < twoDimArray.GetLength(0); rowIndex++)
{
    for (int columnIndex = 0; columnIndex < twoDimArray.GetLength(1); columnIndex++)
    {
        Console.Write($"enter value at twoDimArray[{rowIndex},{columnIndex}]: ");
        twoDimArray[rowIndex, columnIndex] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\n\n");
//sorting of multi-dimensional array is not possible through Sort method
//Array.Sort(twoDimArray);

foreach (int item in twoDimArray)
{
    Console.WriteLine($"value: {item}");
}

int[] target = new int[twoDimArray.Length];
//twoDimArray.CopyTo(target, 0);
//Array.Copy(twoDimArray, target, twoDimArray.Length);
Console.WriteLine("\n\n");
foreach (int item in target)
{
    Console.WriteLine(item);
}




