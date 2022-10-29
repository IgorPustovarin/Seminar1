// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int RaseDegree(int a, int b)
    {
        int result = a;
        for (int count = 1; count < b; count++)
        {
            result = result * a;
        }
        Console.WriteLine($"Возвели число А в степень В получили {result}");
        return result;
        
    }

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В");
int B = int.Parse(Console.ReadLine()!);
RaseDegree(A, B);
