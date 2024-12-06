Console.OutputEncoding = System.Text.Encoding.UTF8;
 
Console.Write("Введіть шлях до вихідного файлу: ");
string? sourceFilePath = Console.ReadLine();

Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
string? destinationFilePath = Console.ReadLine();

try
{
    File.Copy(sourceFilePath, destinationFilePath, true);
    Console.WriteLine("Файл успішно скопійовано!");
}
catch (FileNotFoundException)
{
    Console.WriteLine("Вихідний файл не знайдено. Перевірте шлях.");
}
catch (IOException ex)
{
    Console.WriteLine($"Сталася помилка при копіюванні файлу: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Сталася помилка: {ex.Message}");
}