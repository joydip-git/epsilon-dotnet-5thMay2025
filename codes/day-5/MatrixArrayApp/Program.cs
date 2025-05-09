Console.WriteLine("Welcome to Matrix Array App!");

int size = GetSize();
int[,] twoDimensional = CreateTwoDimensionalArray(size);
int[] singleDimensional = ConvertToSingleDimensionalArray(twoDimensional);
int[] finalArray = ArrangeElementsOfArray(singleDimensional);
PrintElements(finalArray);

static int GetSize()
{
    Console.Write("enter size of the two dimensional array: ");
    return int.Parse(Console.ReadLine());
}

static int[,] CreateTwoDimensionalArray(int size)
{
    int[,] matrixArray = new int[size, size];
    for (int rowIndex = 0; rowIndex < matrixArray.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrixArray.GetLength(1); columnIndex++)
        {
            Console.Write($"enter value at matrixArray[{rowIndex},{columnIndex}]: ");
            matrixArray[rowIndex, columnIndex] = int.Parse(Console.ReadLine());
        }
    }
    return matrixArray;
}

static int[] ConvertToSingleDimensionalArray(int[,] array)
{
    int[] target = new int[array.Length];
    int index = 0;
    for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < array.GetLength(1); columnIndex++)
        {
            target[index] = array[rowIndex, columnIndex];
            index++;
        }
    }
    return target;
}

static int[] ArrangeElementsOfArray(int[] array)
{
    Array.Sort(array);

    int[] result = new int[array.Length];
    int middleIndex = result.Length / 2;
    result[middleIndex] = array[0];

    int leftIndex = middleIndex - 1;
    int rightIndex = middleIndex + 1;

    for (int index = 1; index < array.Length; index++)
    {
        if (index % 2 != 0)
        {
            result[leftIndex] = array[index];
            leftIndex--;
        }
        else
        {
            result[rightIndex] = array[index];
            rightIndex++;
        }
    }
    return result;
}

static void PrintElements(int[] finalArray)
{
    foreach (int item in finalArray)
    {
        Console.WriteLine($"Value: {item}");
    }
}
