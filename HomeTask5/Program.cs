Console.OutputEncoding = System.Text.Encoding.UTF8;

int number1 = 0;
int number2 = 0;
char operation;
int result;

while (true)
{
    while (true)
    {
        Console.Write("Введіть перше число: ");
        try
        {
            number1 = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка, введене значення невірне.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Невідома помилка");
        }
    }
    while (true)
    {
        Console.Write("Введіть дурге число: ");
        try
        {
            number2 = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка, введене значення невірне.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Невідома помилка");
        }
    }

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
            try
            {
                result = number1 / number2;
                Console.WriteLine($"Результат: {number1} / {number2} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Помилка: ділення на нуль.");
            }
            break;
    }
}

