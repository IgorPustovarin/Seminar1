// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.


int Proverka(int n)
    {
        int count = n;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i%j ==0) count++;
            if (count == 2) Console.WriteLine($"{i}, ");
                
            }
        }
        return count;
    } 
Console.WriteLine("Введите число и найдем все простые числа от 1 до этого числа");
int number = int.Parse(Console.ReadLine()!);
Proverka(number);
