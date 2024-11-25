using HomeTask12._1;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть номер числа Фібоначчі: ");

if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    int result = FibonacciCalculator.GetFibonacci(n);
    Console.WriteLine($"Число Фібонначі для n={n}: {result}");
}
else
{
    Console.WriteLine("Будь ласка, введіть дійсне число");
}