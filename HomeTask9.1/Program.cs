﻿Console.OutputEncoding = System.Text.Encoding.UTF8;
/*
 //Task1

int[] numbers = { 2, 9, 6, 4, 5, 67, 83, 31, 23, 1, 8, 10, 45, 7 };

int? secondLargest = FindSecondLargest(numbers);

if (secondLargest.HasValue)
{
    Console.WriteLine($"Second Largest: {secondLargest}");
}
else
{
    Console.WriteLine($"Problem");
}

static int? FindSecondLargest(int[] array)
{
    if (array.Length < 2)
    {
        return null;
    }

    int largest = int.MinValue;
    int secondLargest = int.MinValue;

    foreach (int number in array)
    {
        if (number > largest)
        {
            secondLargest = largest;
            largest = number;
        }
        else if (number > secondLargest && number < largest)
        {
            secondLargest = number;
        }
    }

    return secondLargest == int.MinValue ? (int?)null : secondLargest;
} */

//Task2

/*int[,] array =
{
    { 5, 7, 9 },
    { 1, 3, 6 },
    { 4, 8, 2 }
};

Console.WriteLine("Початковий масив");
PrintArray(array);

int[,] sortedArray = Sort2dArray(array);

Console.WriteLine("\nВідсортований масив: ");
PrintArray(sortedArray);

static int[,] Sort2dArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] tempArray = new int[rows * cols];

    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            tempArray[index++] = array[i, j];
        }
    }

    Array.Sort(tempArray);

    index = 0;
    int[,] sortedArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            sortedArray[i, j] = tempArray[index++];
        }
    }

    return sortedArray;
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}*/

//Task3

/*int[] array = { 1, 2, 3, 4, 5 };

Console.WriteLine("Початковий масив:");
PrintArray(array);

Console.Write("Введіть індекс елемента для видалення: ");
int indexToRemove;
if (int.TryParse(Console.ReadLine(), out indexToRemove))
{
    if (indexToRemove >= 0 && indexToRemove < array.Length)
    {
        int[] newArray = RemoveElementAtIndex(array, indexToRemove);
        Console.WriteLine("\nМасив після видалення:");
        PrintArray(newArray);
    }
    else
    {
        Console.WriteLine("Індекс поза межами масиву.");
    }
}
else
{
    Console.WriteLine("Некоректний ввід.");
}

static int[] RemoveElementAtIndex(int[] array, int index)
{
    int[] newArray = new int[array.Length - 1];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (i != index)
        {
            newArray[j++] = array[i];
        }
    }

    return newArray;
}

static void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }

    Console.WriteLine();
}*/

//Task4

int[,] array =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

Console.WriteLine("Двовимірний масив:");
PrintArray(array);

int diagonalSum = CalculateSymOfDiagonal(array);

Console.WriteLine("\nСума елементів по головній діагоналі: " + diagonalSum);

static int CalculateSymOfDiagonal(int[,] array)
{
    int sum = 0;
    int size = array.GetLength(0);

    for (int i = 0; i < size; i++)
    {
        sum += array[i, i];
    }

    return sum;
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + "\t");
        }

        Console.WriteLine();
    }
}