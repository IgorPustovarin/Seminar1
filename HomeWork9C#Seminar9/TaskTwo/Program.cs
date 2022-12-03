/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Найдем сумму натуральных элементов в промежутке от M до N ");
Console.Write("Введите значение М ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N  ");
Console.WriteLine();
int n = int.Parse(Console.ReadLine()!);

void SumNumbers(int m)
{
    int sum =0;
    for (int i = m; i <= n; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine($"Сумма чисел равна {sum}");
    
}

SumNumbers(m);
