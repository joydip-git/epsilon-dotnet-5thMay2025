namespace DependencyInjectionDemo
{
    public class FileDataAccess : IDataAccess
    {
        public string GetData()
        {
            return "file data";
        }
    }
}
