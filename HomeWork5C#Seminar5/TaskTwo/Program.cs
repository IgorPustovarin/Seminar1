// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите длинну массива");

int ArrayLenght = int.Parse(Console.ReadLine()!);
int SumOdd = 0;
int[] array = new int[ArrayLenght];
    for (int count = 0; count < ArrayLenght; count++)
    {
        array[count] = new Random().Next(1, 20);
        if (count % 2 == 0)
        {
            SumOdd = SumOdd + array[count];
        }
        Console.Write($"{array[count]}, ");
    }
Console.WriteLine($"Сумма чисел на нечетной позиции {SumOdd}");