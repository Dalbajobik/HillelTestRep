using System.Data;

Console.OutputEncoding = System.Text.Encoding.UTF8; // встановлення укр мови

byte dayNumber;
string dayName;

while (true)
{
    Console.WriteLine();
    Console.Write("Напишіть номер дня тижня від 1 до 7: ");
    if (byte.TryParse(Console.ReadLine(), out dayNumber) == false)
    {
        Console.WriteLine("Будь ласка, введіть коректне число.");
        continue;
    }
    switch (dayNumber)
    {
        case 1:
            dayName = "Понеділок";
            break;
        case 2:
            dayName = "Вівторок";
            break;
        case 3:
            dayName = "Середа";
            break;
        case 4:
            dayName = "Четвер";
            break;
        case 5:
            dayName = "П'ятниця";
            break;
        case 6:
            dayName = "Субота";
            break;
        case 7:
            dayName = "Неділя";
            break;
        default:
            Console.WriteLine("Невірний номер дня. Будь ласка, введіть число від 1 до 7.");
            continue;
    }
    Console.WriteLine(dayName);
    break;
}
































/*Console.Write("Напишіть номер дня тижня від 1 до 7: ");
byte dayNumber = byte.Parse(Console.ReadLine()!);
string dayName;

switch (dayNumber)
{
    case 1:
        dayName = "Понеділок";
        break;
    case 2:
        dayName = "Вівторок";
        break;
    case 3:
        dayName = "Середа";
        break;
    case 4:
        dayName = "Четвер";
        break;
    case 5:
        dayName = "П'ятниця";
        break;
    case 6:
        dayName = "Субота";
        break;
    case 7:
        dayName = "Неділя";
        break;
    default:
        dayName = "Невірний номер дня. Будь ласка, введіть число від 1 до 7.";
        break;
}
Console.WriteLine(dayName);
*/