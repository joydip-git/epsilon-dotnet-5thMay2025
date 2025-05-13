OperationalImpl impl = new();

//impl.Add(12, 13);
//Console.WriteLine($"Add Result: {impl.Result}");

//impl.Subtract(12, 13);
//Console.WriteLine($"Subtract Result: {impl.Result}");

//through upcasting
IAdditionOperations addOps = impl;//upcasting
IResult result = impl;//upcasting
addOps.Add(12, 13);
Console.WriteLine($"Add Result: {result.Result}");

ISubtractionOperations subOps = impl;//upcasting
subOps.Subtract(12, 3);
Console.WriteLine($"Subtract Result: {result.Result}");

interface IResult
{
    int Result { get; }
}
interface IAdditionOperations
{
    void Add(int x, int y);
}
interface ISubtractionOperations
{
    void Subtract(int x, int y);
}
class OperationalImpl : IAdditionOperations, ISubtractionOperations, IResult
{
    int result;
    public int Result => result;

    public void Add(int x, int y)
    {
        result = x + y;
    }

    public void Subtract(int x, int y)
    {
        result = x - y;
    }
}
