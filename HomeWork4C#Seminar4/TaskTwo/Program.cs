// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int allSumNumber(int n)
    {
        int result = 0;
        for (int count = 0; count < 10; count++)
        {
            result = result + n % 10;
            //Console.WriteLine(array[count]);
            n = n /10;
        }
        Console.WriteLine($"Сумма всех цифр {result}");
        return result;
    }
Console.WriteLine("Введите число и посчитаем сумму цифр в нем");
int number = int.Parse(Console.ReadLine()!);
allSumNumber(number);