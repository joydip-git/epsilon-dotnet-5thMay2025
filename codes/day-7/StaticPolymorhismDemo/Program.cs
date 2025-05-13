// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Addition addition = new();
addition.Add(12, 13);//1st
addition.Add(14, 15, 16);//2nd
addition.Add(13, 14, 12345678912);//3rd
addition.Add(13, 12345678912, 14);//4th
addition.Add("joydip", " mondal");//5th

class Addition
{
    public void Add(int x, int y)
    {
        Console.WriteLine("1st: " + (x + y));
    }
    public void Add(int x, int y, int z) => Console.WriteLine("2nd: " + (x + y + z));
    public void Add(int x, int y, long z) => Console.WriteLine("3rd: " + (x + y + z));
    public void Add(int x, long y, int z) => Console.WriteLine("4th: " + (x + y + z));
    public void Add(string x, string y) => Console.WriteLine("5th: " + (x + y));
}