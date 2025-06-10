namespace DependencyInjectionDemo
{
    public class Manager
    {
        private IDataAccess dataAccess;

        //when calling this ctor, the client (whoever is creating Manager instance), has to supply an object of a class which implements the IDataAccess interface
        public Manager(IDataAccess dataAccess)
        { 
            this.dataAccess = dataAccess; 
        }

        public string FetchDataFromSource()
        {
            return dataAccess.GetData();
        }

        //public string FetchDataFromSource(DataAccessChoices dataAccessChoices)
        //{
        //    string data;
        //    switch (dataAccessChoices)
        //    {
        //        case DataAccessChoices.FileData:
        //            FileDataAccess fileDataAccess = new FileDataAccess();
        //            data = fileDataAccess.GetData();
        //            break;

        //        case DataAccessChoices.DatabaseData:
        //            data = new DbDataAccess().GetData();
        //            break;

        //        default:
        //            data = string.Empty;
        //            break;
        //    }
        //    return data;
        //}
    }
}
