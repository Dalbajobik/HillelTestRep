using System.Data;
using System.Globalization;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//Task1
/*Console.Write("Введіть ім'я та прізвище через пробіл: ");
string? nameAndSurname = Console.ReadLine();

string[] parts = nameAndSurname.Split(' ');

if  (parts.Length < 2)
{
    Console.WriteLine("Введіт ім'я та прізвище: ");
    return;
}

string firstName = parts[0];
string lastName = parts[1];

if (char.ToLower(firstName[0]) == char.ToLower(lastName[0]))
{
    Console.WriteLine("Прізвище починаються на ту саму букву");
}
else
{
    Console.WriteLine("Прізвища не починаються на одну і ту саму букву");
}
*/

//Task3
/*Console.Write("Введіть рядок, що містить слова, розділені комами: ");

string? input = Console.ReadLine();


string result = input.Replace(" ", "");


Console.WriteLine("Результат без пробілів: " + result);
*/
//Task2

StringBuilder report = new StringBuilder();

report.AppendLine("Звіт подій");
report.AppendLine("Дата: " + DateTime.Now.ToString("dd.MM.yyyy"));
report.AppendLine("Список подій: ");

while (true)
{
    Console.WriteLine("Введіть подію (або 'done' для виходу):");
    string? input = Console.ReadLine();
    if (input.ToLower() == "done")
    {
        break;
    }

    report.AppendLine("- " + input);
}

Console.WriteLine("Фінальний звіт:");
Console.WriteLine(report.ToString());
