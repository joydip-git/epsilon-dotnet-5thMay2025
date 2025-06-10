namespace DependencyInjectionDemo
{
    public class DbDataAccess : IDataAccess
    {
        public string GetData()
        {
            return "db data";
        }
    }
}
