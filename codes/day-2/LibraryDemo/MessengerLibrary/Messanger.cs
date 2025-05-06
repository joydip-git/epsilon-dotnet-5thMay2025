namespace MessengerLibrary
{
    public class Messanger
    {
        //common syntax
        //public string GetMessage(string name)
        //{
        //    return "Welcome " + name;
        //}

        //expression body syntax [applicable for one-liner]

        //1. method without return statment
        //public void GetMessage(string name) => Console.WriteLine("Welcome " + name);

        //2. method with return statment
        public string GetMessage(string name) => "Welcome " + name;

    }
}
