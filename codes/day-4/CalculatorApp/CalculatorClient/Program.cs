using CalculatorLibrary;

//traditional way
//Calculator calculator = new Calculator();

//new feature of instantiation
Calculator calculator = new();

char toContinue = 'n';
do
{
    //1. print the menu
    //Console.WriteLine("1. Add(a)\n2. Subtract(s)\n3. Multiply(m)\n4. Divide(d)");
    PrintMenu();

    //2. ask user choice
    Console.Write("\nenter choice[a/s/m/d]: ");
    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
    char choice = consoleKeyInfo.KeyChar;

    //3.a. accepting first value 
    Console.Write("\nenter value: ");
    int firstValue = int.Parse(Console.ReadLine());
    //3.b. accepting second value
    Console.Write("enter value: ");
    int secondValue = int.Parse(Console.ReadLine());

    //4. perform operation based on choice
    int? result;
    string methodName = null;
    switch (choice)
    {
        case 'a':
            result = calculator.Add(firstValue, secondValue);
            methodName = nameof(calculator.Add);
            break;

        case 's':
            result = calculator.Subtract(firstValue, secondValue);
            methodName = nameof(calculator.Subtract);
            break;

        case 'm':
            result = calculator.Multiply(firstValue, secondValue);
            methodName = nameof(calculator.Multiply);
            break;

        case 'd':
            result = calculator.Divide(firstValue, secondValue);
            methodName = nameof(calculator.Divide);
            break;

        default:
            result = null;
            methodName = null;
            Console.WriteLine("please enter a proper choice");
            break;
    }

    //5. printing result along with method name
    Console.WriteLine(result.HasValue ? $"{methodName} Result : {result.Value}" : "No calculation performed");

    //6. asking user choice for continuation
    Console.Write("enter n/N to terminate or else to continue: ");
    toContinue = char.Parse(Console.ReadLine());
    if (char.IsUpper(toContinue))
        toContinue = char.ToLower(toContinue);

} while (toContinue != 'n');

static void PrintMenu() => Console.WriteLine("1. Add(a)\n2. Subtract(s)\n3. Multiply(m)\n4. Divide(d)");

