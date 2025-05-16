namespace CalculationLibrary
{
    public class Calculation
    {
        public int Divide(int value, int divisor)
        {
            try
            {
                if (divisor == 0)
                {
                    ArgumentException ex = new ArgumentException($"{nameof(divisor)} should not be zero");
                    throw ex;
                }
                int result = value / divisor;
                return result;
            }
            catch (DivideByZeroException ex)
            {
                CalculationException exception = new CalculationException(ex.Message, ex);
                throw exception;
            }
            catch (ArgumentException ex)
            {
                CalculationException exception = new CalculationException(ex.Message, ex);
                throw exception;
            }
            //catch (DivideByZeroException)
            //{
            //    throw;
            //}
            //catch (ArgumentException)
            //{
            //    throw;
            //}
            catch (Exception ex)
            {
                // throw;
                CalculationException exception = new CalculationException(ex.Message, ex);
                throw exception;
            }
        }
    }
}
