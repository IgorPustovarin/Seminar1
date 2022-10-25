// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число, увидим все четные числа от 1 до введенного числа ");

int number = int.Parse(Console.ReadLine()!);
int count = 2;
Console.Write($"Все четные числа от 1 до {number} следующие: ");
while(count <= number)
{
    Console.Write($"{count}, ");
    count = count +2;
}
Console.WriteLine("Вывели все четные числа в заданном диапазоне");