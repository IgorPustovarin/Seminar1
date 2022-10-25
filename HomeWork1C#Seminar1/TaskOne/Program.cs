// Написать программу которая на вход принимает два числа и выдает, какое число больше, а какое меньше
Console.WriteLine("Введите число a");

int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите_число_b");

int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
    {
    Console.WriteLine($"max = {number1}");
    Console.Write($"min = {number2}");    
    }
else if (number1 < number2)
    {
    Console.WriteLine($"max = {number2}");
    Console.Write($" min = {number1}");
    }
else
    {
    Console.Write("Числа одинаковые");
    }