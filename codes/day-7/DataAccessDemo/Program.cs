Console.WriteLine("1. data access from file");
Console.WriteLine("2. data access from database");

Console.Write("enter choice[1/2]: ");
int choice = int.Parse(Console.ReadLine());

//declaring a reference variable of abstract base class,  so that we can store reference of its child class object
DataAccess dataAccess = Create(choice);
Console.WriteLine(dataAccess.GetData());

static DataAccess Create(int choice)
{
    //declaring a reference variable of abstract base class, so that in future we can store reference of its child class object
    DataAccess dataAccess;
    switch (choice)
    {
        case 1:
            dataAccess = new TextFileDataAccess("file path");
            break;

        case 2:
            dataAccess = new DbDataAccess("db path");
            break;

        default:
            dataAccess = null;
            break;
    }
    return dataAccess;
}
abstract class DataAccess
{
    string path;

    public DataAccess(string path)
    {
        this.path = path;
    }

    public string Path
    {
        get { return path; }
        set { path = value; }
    }
    /*
     * public absract string Path
       {
            get;
            set;
       }
     */
    //public virtual string GetData() => string.Empty;
    public abstract string GetData();
}

class TextFileDataAccess : DataAccess
{

    public TextFileDataAccess(string filePath) : base(filePath) { }

    //method contains logic to read data from a text file
    public override string GetData() => $"file data from file: {Path}";
}

class DbDataAccess : DataAccess
{
    public DbDataAccess(string dbPath) : base(dbPath)
    {
    }

    //method contains logic to read data from database table
    public override string GetData()
    {
        return $"db data from: {Path}";
    }
}
