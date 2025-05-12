Console.WriteLine("inheritance");

B objB = new(-1, -1) { AData = 100, BData = 200 };
//Console.WriteLine($"{nameof(objB.AData)}:{objB.AData}");
//Console.WriteLine($"{nameof(objB.BData)}:{objB.BData}");

Console.WriteLine(objB.PrintData());

class A
{
    //protected int aData;
    private int aData;

    public A() { }

    public A(int aData)
    {
        this.aData = aData;
    }

    public int AData
    {
        get => aData;
        set => aData = value;
    }

    public string PrintData() => $"A Data: {aData}";
}
class B : A
{
    int bData;

    public B() : base(0) { }

    public B(int aData, int bData) : base(aData)
    {
        this.bData = bData;
        //this.aData = aData;
    }

    public int BData
    {
        get => bData;
        set => bData = value;
    }

    public string PrintData() => $"{base.PrintData()}, B Data: {bData}";
}
