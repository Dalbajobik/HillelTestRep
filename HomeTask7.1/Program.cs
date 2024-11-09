Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] playBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

BuildPlayBoard();

while (true)
{
    PlayerChoiceOnBoard("X", 1);
    bool isGameOver = CheckForWinnerAndDraw();
    if (isGameOver)
    {
        break;
    }

    PlayerChoiceOnBoard("O", 2);
    isGameOver = CheckForWinnerAndDraw();
    if (isGameOver)
    {
        break;
    }
}

void BuildPlayBoard()
{
    for (int i = 0; i < playBoard.Length; i++)
    {
        Console.Write($" {playBoard[i]} |");
        if ((i + 1) % 3 == 0 && i != 8)
        {
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
        else if (i == 8)
        {
            Console.WriteLine();
        }
    }
}
void PlayerChoiceOnBoard(string playerChoice, byte playerNumber)
{
    while (true)
    {
        Console.Write($"\n{playerNumber}. player choice: ");
        string playerChoiceOnField = Console.ReadLine()!;
        Console.WriteLine();
        if (int.TryParse(playerChoiceOnField, out int number) && number > 0 && number < 10 && playBoard[int.Parse(playerChoiceOnField) - 1] == playerChoiceOnField)
        {
            playBoard[number - 1] = playerChoice;
            Console.ResetColor();
            BuildPlayBoard();
            break;
        }
    }
}
bool CheckForWinnerAndDraw()
{
    for (int i = 0; i < 3; i++)
    {
        bool firstPlayerWin = (playBoard[3 * i] == "X" && playBoard[3 * i + 1] == "X" && playBoard[3 * i + 2] == "X") ||
                              (playBoard[i] == "X" && playBoard[i + 3] == "X" && playBoard[i + 6] == "X") ||
                              (playBoard[0] == "X" && playBoard[4] == "X" && playBoard[8] == "X") ||
                              (playBoard[2] == "X" && playBoard[4] == "X" && playBoard[6] == "X");
        bool secondPlayerWin = (playBoard[3 * i] == "O" && playBoard[3 * i + 1] == "O" && playBoard[3 * i + 2] == "O") ||
                               (playBoard[i] == "O" && playBoard[i + 3] == "O" && playBoard[i + 6] == "O") ||
                               (playBoard[0] == "O" && playBoard[4] == "O" && playBoard[8] == "O") ||
                               (playBoard[2] == "O" && playBoard[4] == "O" && playBoard[6] == "O");
        if (firstPlayerWin)
        {
            Console.WriteLine("\nПерший гравець переміг!");
            return true;
        }
        if (secondPlayerWin)
        {
            Console.WriteLine("\nДругий гравець переміг!");
            return true;
        }
    }

    int boardUnitsFilled = 0;

    foreach (string slot in playBoard)
    {
        if (slot == "X" || slot == "O")
        {
            boardUnitsFilled++;
        }
    }

    if (boardUnitsFilled == 9)
    {
        Console.WriteLine("\nНічия!");
        return true;
    }

    return false;
}
