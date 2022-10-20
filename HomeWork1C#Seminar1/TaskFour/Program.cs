// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число, увидим все четные числа от 1 до введенного числа ");

int a = int.Parse(Console.ReadLine()!);
int count = 2;
int b = 0;
b = a % 2;

if (b == 0)
{
    a = a + 1;
}

while(count < a)
{
    Console.Write("Число ");
    Console.WriteLine(count);
    count = count +2;
}
Console.WriteLine("Вывели все четные числа в нашем диапазоне");
