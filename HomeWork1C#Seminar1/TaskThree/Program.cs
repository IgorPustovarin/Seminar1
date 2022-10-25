// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число, проверим его на чётность ");

int number = int.Parse(Console.ReadLine()!);
//int remains = 3;
//remains = number % 2;

if (number % 2 == 0)
{
    Console.WriteLine("Введеное вами число чётное и делится на два без остатка");
}
else 
{
    Console.WriteLine("Введеное число нечетное");
}
Console.WriteLine("Спасибо за внимание");