// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
    for (int count = 0; count < 8; count++)
    {
        Console.WriteLine("Введите число, нужно 8 чисел через Enter");
        int number = int.Parse(Console.ReadLine()!);
        array[count] = number;
    }
    Console.WriteLine("Поздравляю, сформировали массив из 8 элементов");
    for (int count = 0; count < 8; count++)
    {
        Console.Write($"{array[count]}, ");
    }