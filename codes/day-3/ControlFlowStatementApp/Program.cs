//int value = 0;
//while (value <= 5)
//{
//    Console.WriteLine($"Value: {value}");
//    value++;
//}

//do
//{
//    Console.WriteLine($"Value: {value}");
//    value++;
//} while (value <= 5);

Console.WriteLine("choices for background colors: \n1. b for Blue\n2. w for White\n3. y for Yellow");
Console.Write("enter choice[b/w/y] in lowercase: ");

//string choiceStr = Console.ReadLine();
//char choice = char.Parse(choiceStr);

//or (since the input is a single character)
int choiceInt = Console.Read();
char choice = Convert.ToChar(choiceInt);

//char choice = 'b';

switch (choice)
{
    case 'w':
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        break;

    case 'b':
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        break;

    case 'y':
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        break;

    default:
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        break;
}

Console.WriteLine($"Choice value is {choice}, ASCII value is {Convert.ToInt32(choice)}");