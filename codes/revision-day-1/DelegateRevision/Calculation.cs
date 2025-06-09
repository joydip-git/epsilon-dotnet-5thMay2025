namespace DelegateRevision
{
    class Calculation
    {
        public bool IsOdd(int value)
        {
            return (value % 2 != 0);
        }
        public static bool IsGreater(int value)
        {
            return value > 5;
        }
    }
}
