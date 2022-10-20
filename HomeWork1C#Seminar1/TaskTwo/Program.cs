// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число a");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите_число_b");

int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число с");

int c = int.Parse(Console.ReadLine()!);

int max = a;

if (a < b) max = b;
if (a < c) max = c;
//if (b < c) max = c;

Console.Write("max = ");
Console.WriteLine(max);
