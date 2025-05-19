namespace CustomExceptionHandling
{
    internal class AgeLessThanEighteenException:ApplicationException
    {
        public AgeLessThanEighteenException():base("age is less than eighteen") { }

        public AgeLessThanEighteenException(string? message) : base(message) { }

        public AgeLessThanEighteenException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
