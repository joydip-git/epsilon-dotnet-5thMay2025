int x = 10;
Print();

//static void Print()
void Print()
{
    Console.WriteLine("Hello from a local function!" + x);
}

/*
namespace LocalFunctionApp
{
    internal class Program
    {
        static void Main()
        {
            int x = 10;
            Print();
            void Print()
            {
                Console.WriteLine("Hello from a local function!" + x);
            }
        }
    }
}
*/
