Console.OutputEncoding = System.Text.Encoding.UTF8;
//Завдання 1,2
/*int[] array = new int[10];
Random ramdon = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = ramdon.Next(-10, 11);
}

Console.WriteLine("Елменти масиву з парними індексами: ");

for  (int i = 0;i < array.Length; i += 2) 
{
    Console.WriteLine($"Індекс {i}: {array[i]}");
}

int sum = 0;

for (int j = 0; j < array.Length; j++)
{
    sum += array[j];
}

Console.WriteLine($"Сума елементів масиву: {sum}");

if (sum >= 0) 
{
    Console.WriteLine("Сума елементів масиву є додатня");
}   
else 
{
    Console.WriteLine("Сума елементів є від'ємна");
}*/
//Завдання 3

/*int[,] multiplicationTable = new int[9, 9];

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multiplicationTable[i, j] = (i + 1) * (j + 1);
    }
}

Console.WriteLine("Таблиця множення від 1 до 9: ");

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write($"{multiplicationTable[i, j],4}");
    }
    Console.WriteLine();
}*/

//Завдання 4
/*int[,] boxArray = new int[5, 5];
Random random = new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        boxArray[i, j] = random.Next(1, 101);
    }
}

Console.WriteLine("Двовимірний масив: ");

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{boxArray[i, j],4}");
    }
    Console.WriteLine();
}

int maxElement = int.MinValue;
int minElement = int.MaxValue;
int maxRow = 0, maxCol = 0;
int minRow = 0, minCol = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (boxArray[i, j] > maxElement)
        {
            maxElement = boxArray[i, j];
            maxRow = i;
            maxCol = j;
        }
        if (boxArray[i, j] < minElement)
        {
            minElement = boxArray[i, j];
            minRow = i;
            minCol = j;
        }
    }
}

Console.WriteLine($"\nМаксимальний елемент: {maxElement} (координати: [{maxRow}, {maxCol}])");
Console.WriteLine($"Мінімальний елемент: {minElement} (координати: [{minRow}, {minCol}])");*/

//Завдання 5
int days;

Console.Write("Введітькількість днів: ");
if(int.TryParse(Console.ReadLine(), out days)) 
{
    DaysOfWeek currentDay = DaysOfWeek.Monday;
    DaysOfWeek resultDay = (DaysOfWeek)((int)currentDay + (days % 7));
    Console.WriteLine($"Очікуваний день: {resultDay}");
}
else
{
    Console.WriteLine("Будь ласка введіть коректне число");
}

enum DaysOfWeek 
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
