// Написать программу которая на вход принимает два числа и выдает, какое число больше, а какое меньше
Console.WriteLine("Введите число a");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите_число_b");

int b = int.Parse(Console.ReadLine()!);

int max = 0;
int min = 0;

if (a > b) max = a;
if (a > b) min = b;
if (a < b) max = b;
if (a < b) min = a;
if (a == b) Console.WriteLine("Числа одинаковы");

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);