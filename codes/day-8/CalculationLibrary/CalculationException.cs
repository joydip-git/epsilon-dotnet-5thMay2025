namespace CalculationLibrary
{
    public class CalculationException : ApplicationException
    {
        public CalculationException() : base("some calculation error occurred") { }

        public CalculationException(string? message) : base(message) { }

        public CalculationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
