namespace BasicASPNETApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to ASP.NET Core");

        //extending the console app with hosting feature to create a Web host and using that to create a web application


        //1. creating a builder
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        //2. configuring the web host builder 

        //3. creating the web host
        WebApplication app = builder.Build();

        app.UseLoggingMiddleware("from joydip");
        //creating request endpoints through Map middleware
        app.Map("/", () => "welcome to asp.net core web endpoint for HTTP GET method");
        app.Map("/welcome", () => "Welcome Karthik");

        //middleware (terminal middleware)
        //this runs the web app (host) blocks the Main method from exiting untill and unless you press Ctrl+C key in the terminal/console
        app.Run();
    }
}