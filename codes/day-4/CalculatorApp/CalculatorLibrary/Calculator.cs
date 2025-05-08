namespace CalculatorLibrary
{
    /// <summary>
    /// a class with methods to apply computation logic on any given two numbers, such as addition, subtraction, multiplication and divsion
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// The method to add two integer type values
        /// </summary>
        /// <param name="firstNumber">first value</param>
        /// <param name="secondNumber">second value</param>
        /// <returns>
        /// retruns the addition result of those two values passed as arguments
        /// </returns>
        public int Add(int firstNumber, int secondNumber) => firstNumber + secondNumber;

        /// <summary>
        /// The method to subtract one integer type value from another integer type value
        /// </summary>
        /// <param name="firstNumber">first value</param>
        /// <param name="secondNumber">second value</param>
        /// <returns>
        /// retruns the subtraction result of those two values passed as arguments
        /// </returns>
        public int Subtract(int firstNumber, int secondNumber) => firstNumber - secondNumber;

        /// <summary>
        /// The method to mutiply one integer type value by another integer type value
        /// </summary>
        /// <param name="firstNumber">first value</param>
        /// <param name="secondNumber">second value</param>
        /// <returns>
        /// retruns the multiplication result of those two values passed as arguments
        /// </returns>
        public int Multiply(int firstNumber, int secondNumber) => firstNumber * secondNumber;

        /// <summary>
        /// The method to divide one integer type value by another integer type value
        /// </summary>
        /// <param name="firstNumber">first value</param>
        /// <param name="secondNumber">second value</param>
        /// <returns>
        /// retruns the division result of those two values passed as arguments
        /// </returns>
        public int Divide(int firstNumber, int secondNumber) => firstNumber / secondNumber;
    }
}
