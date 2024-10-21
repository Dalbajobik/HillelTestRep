Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення укр. мови

double number1;
double number2;
char operation;
double result;

while (true)
{
    // Введення першого числа з перевіркою
    Console.Write("Введіть перше число:");
    if (!double.TryParse(Console.ReadLine(), out number1))
    {
        Console.WriteLine("Будь ласка, введіть дійсне число.");
        continue;
    }

    // Введення другого числа з перевіркою
    Console.Write("Введіть друге число:");
    if (!double.TryParse(Console.ReadLine(), out number2))
    {
        Console.WriteLine("Будь ласка, введіть дійсне число.");
        continue;
    }

    // Введення математичної дії з перевіркою
    while (true)
    {
        Console.Write("Введіть математичну дію (+, -, *, /):");
        operation = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
        {
            break;
        }
        else
        {
            Console.WriteLine("Невідома операція! Спробуйте ще раз.");
        }
    }

    // Обчислення результату
    switch (operation)
    {
        case '+':
            result = number1 + number2;
            Console.WriteLine($"Результат: {number1} + {number2} = {result}");
            break;
        case '-':
            result = number1 - number2;
            Console.WriteLine($"Результат: {number1} - {number2} = {result}");
            break;
        case '*':
            result = number1 * number2;
            Console.WriteLine($"Результат: {number1} * {number2} = {result}");
            break;
        case '/':
            if (number2 != 0)
            {
                result = (double)number1 / number2;
                Console.WriteLine($"Результат: {number1} / {number2} = {result}");
            }
            else
            {
                Console.WriteLine("Помилка: Ділення на нуль!");
            }
            break;
    }
}
