// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);

while(number > 1000)
{
    number = number / 10;
}

if (99 < number)
{
    Console.Write("Третья цифра числа ");
    Console.WriteLine(number = number % 10);
}
else
{
    Console.Write("Третьеей цифры в числе нет ");
}

