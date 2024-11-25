namespace HomeTask12._1;

internal static class FibonacciCalculator
{
    internal static int GetFibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}