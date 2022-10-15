// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
Console.WriteLine("Вееди число1");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Вееди число2");

int b = int.Parse(Console.ReadLine()!);

int c = b / a;

if (c == a)
{
    Console.WriteLine("Это квадрат числа");
}
else 
{
    Console.WriteLine("Не является квадратом");
}
