Console.OutputEncoding = System.Text.Encoding.UTF8;

//task1
/*int allPersonal;
decimal totalSalary = 0;

Console.Write("Будь ласка, введіть кількість працівників: ");
allPersonal = int.Parse(Console.ReadLine()!);

for (int i = 1; i<= allPersonal; i++) 
{
    Console.Write($"Напишіть зарплатню кожного працівника {i}: ");
    decimal workerSalary = decimal.Parse(Console.ReadLine()!);
    totalSalary += workerSalary;
}

decimal averageSalary = totalSalary / allPersonal;

Console.WriteLine($"Середній заробіток: {averageSalary} ");*/

//task2
/*const char specialSymbol = '*';
int numbersOfRows;

Console.Write("Введіть кількість рядків графіка: ");
numbersOfRows = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= numbersOfRows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(specialSymbol);
    }
    Console.WriteLine();
}*/

//task3
/*.Write("Введіть число: ");

int limitNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Прості числа від 1 до {limitNumber}:");

for (int number = 2; number <= limitNumber; number++)

{
    bool isSimple = true;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isSimple = false;
            break;
        }
    }

    if (isSimple)
    {
        Console.Write(number + " ");
    }
} */

//task 4
/*Console.Write("Введіть пароль: ");

string? password = Console.ReadLine();


if (IsValidPassword(password))
{

    Console.WriteLine("Пароль прийнятний.");
}
else
{
    Console.WriteLine("Пароль не відповідає вимогам.");
}

static bool IsValidPassword(string password)
{
    if (password.Length < 8)
    {
        return false;
    }

    bool hasDigit = false;

    bool hasSpecialChar = false;

    for (char digit = '0'; digit <= '9'; digit++)

    {

        if (password.Contains(digit.ToString()))
        {
            hasDigit = true;
            break;
        }
    }

    char[] specialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '{', '}', '[', ']', '|', ':', ';', '"', '\'', '<', '>', ',', '.', '?', '/' };

    foreach (char specialChar in specialChars)
    {
        if (password.Contains(specialChar.ToString()))
        {
            hasSpecialChar = true;
            break;
        }
    }

    return hasDigit && hasSpecialChar;
} */

//task 5
/*int readNumberFromUser;
int firstNumber = 0;
int secondNumber = 1;

Console.Write("Введіть число: ");

while (!int.TryParse(Console.ReadLine(), out readNumberFromUser) || readNumberFromUser <= 0)
{
    Console.Write("Будь ласка, введіть дійсно позитивне число: ");
}

Console.WriteLine($"Перші {readNumberFromUser} чисел Фібоначчі: ");

for (int i = 0; i < readNumberFromUser; i++)
{
    if (i == 0)
    {
        Console.Write(firstNumber + " ");
    }
    else if (i == 1)
    {
        Console.Write(secondNumber + " ");
    }
    else
    {
        int next = firstNumber + secondNumber;
        Console.Write(next + " ");
        firstNumber = secondNumber;
        secondNumber = next;
    }
} */

//task6
/*Console.Write("Введіть кількість годин, відпрацьованих за день: ");
string? hoursInput = Console.ReadLine();
double hours;

while (!double.TryParse(hoursInput, out hours) || hours < 0)
{
    Console.Write("Будь ласка, введіть дійсне, невід'ємне число для кількості годин: ");
    hoursInput = Console.ReadLine();
}

Console.Write("Введіть розмір годинної ставки: ");
string? rateInput = Console.ReadLine();
decimal hourlyRate;

while (!decimal.TryParse(rateInput, out hourlyRate) || hourlyRate < 0)
{
    Console.Write("Будь ласка, введіть дійсне, невід'ємне число для годинної ставки: ");
    rateInput = Console.ReadLine();
}

decimal dailyPayment = (decimal)hours * hourlyRate;
Console.WriteLine($"Оплата за день: {dailyPayment} грн.");*/

//task7
/*int number;

Console.Write("Введіть додятнє число: ");
number = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= 10; i++) 
{
    Console.WriteLine($"{number} * {i} = {number * i}");
}*/

//task8
Console.Write("Введіть число для перевірки на простоту: ");
string? input = Console.ReadLine();
int number;

if (!int.TryParse(input, out number) || number < 2)
{
    Console.WriteLine("Будь ласка, введіть ціле число, більше або дорівнює 2.");
    return;
}

bool isPrime = IsPrime(number);

if (isPrime)
{
    Console.WriteLine($"{number} є простим числом.");
}
else
{
    Console.WriteLine($"{number} не є простим числом.");
}
static bool IsPrime(int num)
{
    if (num < 2) return false;

    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}