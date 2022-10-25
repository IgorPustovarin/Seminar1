// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число number1");

int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число number2");

int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число number3");

int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number1 < number2) max = number2;
if (number1 < number3) max = number3;

Console.WriteLine($"max = {max}");
