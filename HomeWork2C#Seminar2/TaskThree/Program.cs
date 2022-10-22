// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели ");
int numberday = int.Parse(Console.ReadLine()!);

if (5 < numberday && numberday < 8)
{
    Console.WriteLine("Выходной день");
}
else if (0 < numberday && numberday < 6)
{
    Console.WriteLine("Рабочий день");
}