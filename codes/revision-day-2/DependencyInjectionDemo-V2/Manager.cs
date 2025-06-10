namespace DependencyInjectionDemo
{
    public class Manager : IManager
    {
        private IDataAccess dataAccess;

        public Manager(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public string FetchDataFromSource()
        {
            return dataAccess.GetData();
        }
    }
}
