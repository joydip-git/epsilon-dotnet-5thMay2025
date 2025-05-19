using CalculationLibrary;

int result = 0;
try
{
    Calculation calculation = new Calculation();
    result = calculation.Divide(12, 0);       
}
catch (CalculationException ex)
{
    Console.WriteLine($"Original Exception: {(ex.InnerException?.GetType().Name)}");
    Console.WriteLine($"Message: {ex.InnerException?.Message}");
    Console.WriteLine($"Method: {ex.InnerException?. TargetSite }");
    Console.WriteLine($"Source: {ex.InnerException?.Source}");
    //Console.WriteLine($"Stack info: {ex.InnerException?.StackTrace}");
    Console.WriteLine(ex.StackTrace);
}
//as fail-safe option use generic catch block
catch (Exception ex)
{    
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine($"Method: {ex.TargetSite}");
    Console.WriteLine($"Source: {ex.Source}");
    Console.WriteLine($"Stack info: {ex.StackTrace}");
}
finally
{
    Console.WriteLine(result);
}
/*
static int Divide( int value, int divisor)
{
    try
    {
        int result = value / divisor;
        return result;
    }
    catch (Exception)
    {
        throw;
    }
    //catch (DivideByZeroException ex)
    //{
    //    log before you rethrow
    //    throw ex;
    //}
}
*/