Console.OutputEncoding = System.Text.Encoding.UTF8;

string secretWord = "нонконформізм";
char[]  guessedWord = new string('_', secretWord.Length).ToCharArray();
int maxAttempts = 4;
int attempts = 0;
bool isWordGuessed = false;

Console.WriteLine("Ласкова просимо до гри!");
Console.WriteLine($"Вгадайте слово: {new string(guessedWord)}");

while (attempts < maxAttempts && !isWordGuessed)
{
    Console.Write("Введіть букву: ");
    char guessedLetter = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (Array.Exists(guessedWord, x => x == guessedLetter))
    {
        Console.WriteLine("Ви вже вгадали цю літеру, спробуйте іншу");
        continue;
    }
    
    if(secretWord.Contains(guessedLetter))
    {
        Console.WriteLine();
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == guessedLetter)
            {
                guessedWord[i] = guessedLetter;
            }
        }   
    }
    else
    {
        attempts++;
        Console.WriteLine($"Не вірно у вас залишилось {maxAttempts - attempts} спроб");
    }
    
    Console.WriteLine($"Слово: {new string(guessedWord)}");
    
    isWordGuessed = new string(guessedWord) == secretWord;
}

if (isWordGuessed)
{
    Console.Write($"Вітаємо ви виграли, слово: " + secretWord);
}
else
{
    Console.WriteLine("на жаль ви програли. Задане слово: " + secretWord);
}

