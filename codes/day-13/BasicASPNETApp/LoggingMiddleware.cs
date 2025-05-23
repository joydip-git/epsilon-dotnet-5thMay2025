namespace BasicASPNETApp
{
    public class LoggingMiddleware
    {
        RequestDelegate requestDelegate;
        ILogger<LoggingMiddleware> logger;
        string addtionalInfo;

        public LoggingMiddleware(
            RequestDelegate requestDelegate, 
            ILogger<LoggingMiddleware> logger, 
            string addtionalInfo)
        {
            this.requestDelegate = requestDelegate;
            this.logger = logger;
            this.addtionalInfo = addtionalInfo;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            HttpRequest requestObject = context.Request;
            string path = requestObject.Path;

            logger.LogInformation($"request path: {path} \n\tadditional info: {addtionalInfo}");
            await requestDelegate(context);
        }
    }

    public static class CustomMiddlewares
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder app, string data)
        {
            //to add a middleware to the request processing pipline
            return app.UseMiddleware<LoggingMiddleware>(data);
        }
    }
}
