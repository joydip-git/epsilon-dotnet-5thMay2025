using CalculatorLibrary;
using System.Reflection;

namespace CalculatorClientWithoutTopLevlStatement
{
    internal class Sample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample...");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Calculate();
        }

        private static char Calculate()
        {
            Calculator calculator = new();
            char toContinue = 'n';
            do
            {
                //1. print the menu
                PrintMenu();

                //2. ask user choice               
                char choice = GetUserChoice();

                //3.a. accepting first value 
                int firstValue = GetValue();
                //3.b. accepting second value
                int secondValue = GetValue();

                //4. perform operation based on choice

                //record feature
                //(int? result, string methodName) = PerformCalculation(choice, firstValue, secondValue, calculator);

                CalculationResult opResult = PerformCalculation(choice, firstValue, secondValue, calculator);             

                //5. printing result along with method name
                //PrintResultWithMethodName(result, methodName);
                PrintResultWithMethodName(opResult.Result, opResult.OperationName);

                //6. asking user choice for continuation
                GetUserDecisionForContinuation(ref toContinue);

            } while (toContinue != 'n');
            return toContinue;
        }

        static void PrintMenu() => Console.WriteLine("1. Add(a)\n2. Subtract(s)\n3. Multiply(m)\n4. Divide(d)");

        static char GetUserChoice()
        {
            Console.Write("\nenter choice[a/s/m/d]: ");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            char choice = consoleKeyInfo.KeyChar;
            return choice;
        }

        static int GetValue()
        {
            Console.Write("\nenter value: ");
            int value = int.Parse(Console.ReadLine());
            return value;
        }

        //static (int?,string) PerformCalculation(int choice, int firstValue, int secondValue, Calculator calculator)
        static CalculationResult PerformCalculation(int choice, int firstValue, int secondValue, Calculator calculator)
        {
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
            //return (result,methodName);
            return new CalculationResult(result, methodName);
        }

        static void PrintResultWithMethodName(int? result, string methodName) => Console.WriteLine(result.HasValue ? $"{methodName} Result : {result.Value}" : "No calculation performed");

        static void GetUserDecisionForContinuation(ref char decision)
        {
            Console.Write("enter n/N to terminate or else to continue: ");
            decision = char.Parse(Console.ReadLine());
            if (char.IsUpper(decision))
                decision = char.ToLower(decision);
        }
    }    
}
