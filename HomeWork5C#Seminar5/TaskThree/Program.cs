// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[5];
        //array[0] = 1;
    for (int count = 0; count < 5; count++)
    {
        array[count] = new Random().Next(1, 20);
        Console.Write($"{array[count]}, ");
    }
          int minNumber = array[0];
          int maxNumber = array[0];
          for (int count = 0; count < 5; count++)
    {
        if (array[count] > maxNumber)
        {
            maxNumber = array[count];
        }
        if (array[count] < minNumber)
        {
            minNumber = array[count];
        }
    }
Console.WriteLine();
Console.WriteLine($"Разница между максимальным {maxNumber} и минимальным {minNumber} элементом массива равна {maxNumber - minNumber}");