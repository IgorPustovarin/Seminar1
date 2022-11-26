// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = new Random().Next(1,10);
        
        }
    }
}

void SearchIndex(int[,] mas)
{
    Console.WriteLine("Нужно ввести через Enter первый индекс массива");
    int indexOne = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Нужно ввести второй индекс массива");
    int indexTwo = int.Parse(Console.ReadLine()!);

    if (indexOne < mas.GetLength(0) && indexTwo < mas.GetLength(1))
    {
        Console.Write($"Под данным индексом массива содержится {mas[indexOne, indexTwo]}");
    }
    else
    {
        Console.Write("Данного индекса не существует");
    }
}
int[,] matrix = new int [4, 4];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SearchIndex(matrix);




