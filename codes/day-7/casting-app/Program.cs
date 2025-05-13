// A objA = new A();
// B objB = new B();

//upcasting: storing reference of derived class object in base class variable
Console.WriteLine("1. B \n2. C");
int choice = int.Parse(Console.ReadLine());

A obj = Create(choice);
Console.WriteLine($"Result: {obj.GetData()}");

//is operator: checks if the object is of a specific type
//as operator: performs safe casting

if (obj is B objB)
{
    objB.bData = 100;
    Console.WriteLine($"Result: {objB.Show()}");
}
else if (obj is C objC)
{
    objC.cData = 200;
    Console.WriteLine($"Result: {objC.Print()}");
}
/*
if (obj is B)
{
    B objB = (B)obj;// safe casting using () operator
    objB.bData = 100;
    Console.WriteLine($"Result: {objB.Show()}");
}
else if (obj is C)
{
    C objC = obj as C;// safe casting using as operator
    objC.cData = 200;
    Console.WriteLine($"Result: {objC.Print()}");
}
*/
static A Create(int choice)
{
    A obj;
    switch (choice)
    {
        case 1:
            obj = new B();
            break;

        case 2:
            obj = new C();
            break;

        default:
            obj = null;
            break;
    }
    return obj;
}
class A
{
    public int aData;
    public virtual string GetData() => $"A Data: {aData}";
}
class B : A
{
    public int bData;

    // public string GetData() => $"A Data: {aData}";
    public override string GetData() => $"{base.GetData()}, B Data: {bData}";
    public string Show() => $"A Data: {aData}, B Data: {bData}";
}

class C : A
{
    public int cData;

    // public string GetData() => $"A Data: {aData}";
    public override string GetData() => $"{base.GetData()}, C Data: {cData}";
    public string Print() => $"A Data: {aData}, C Data: {cData}";
}
