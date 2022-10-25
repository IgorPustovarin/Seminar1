// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
int result = 1;

while(count <= number)
{
    result = result * count;
    count ++;
}
Console.WriteLine(result);
