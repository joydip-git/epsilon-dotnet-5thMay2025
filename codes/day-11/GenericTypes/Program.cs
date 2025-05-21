
Calculation calculation = new Calculation();
calculation.Add<int, int>(12, 13);
calculation.Add<string, string>("epsilon", "bangalore");
calculation.Add<int, long>(12, 123456789123);

DataList<int> list = new DataList<int>();
list.Add(12);
list.Add(13);

Operations<int> intOps = new Operations<int>();
intOps.Add(12, 13);

Operations<decimal> decOps = new Operations<decimal>();
decOps.Add(12.34M, 23.45M);

class Calculation
{
    //generic method with/without constraints for type parameters
    //T1 and T2 => type parameters

    //public void Add<T1, T2>(T1 x, T2 y) where T1 : class where T2 : class [T1 and T2 should be reference type]
    //public void Add<T1, T2>(T1 x, T2 y) where T1 : struct where T2 : struct [T1 and T2 should be value type]
    public void Add<T1, T2>(T1 x, T2 y)
    { }

    //strongly-typed methods
    //public void Add(int x, int y) { }
    //public void Add(string a, string b) { }
    //public void Add(int x, long l) { }
}
interface IOperations<T>
{
    void Add(T x, T y);
    //void Add(int x, int y);
}
class Operations<T> : IOperations<T> where T : struct // T must be a value type
{
    public void Add(T x, T y)
    {

    }
    //public void Add<T1, T2>(T1 x, T2 y) { }
    public void Add(int x, int y) { }
}
interface IDataCollection<T>
{
    int Count { get; }
    int Capacity { get; }
    void Add(T item);
}
interface IDataList<T>
{
    void Insert(int index, T item);
}
class DataList<T> : IDataCollection<T>, IDataList<T>
{
    private T[] items;
    int index;
    public DataList()
    {
        items = new T[4];
    }
    public void Add(T item)
    {
        if (index == items.Length)
        {
            T[] temp = new T[items.Length];
            items.CopyTo(temp, 0);
            items = new T[items.Length * 2];
            temp.CopyTo(items, 0);
            temp = null;
        }

        items[index] = item;
        index++;
    }
    public int Count => index;
    public int Capacity => items.Length;

    public void Insert(int indexToAdd, T item)
    {

    }
}