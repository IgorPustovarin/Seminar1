// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int NumberPositive = 0;
int[] Array = new int [10];
    for (int count = 0; count < 10; count++)
    {
        Array[count] = new Random().Next(100, 999);
        if (Array[count] % 2 == 0)
        {
            NumberPositive = NumberPositive + 1;
        }
        Console.Write($"{Array[count]}, ");
    }
Console.WriteLine($"Количество четных чисел {NumberPositive}");