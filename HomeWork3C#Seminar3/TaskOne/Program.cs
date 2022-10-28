// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int[] inputArray(int n)
    {
        int[] array = new int[5];
        for (int count = 0; count < 5; count++)
        {
            array[count] = n % 10;
            //Console.WriteLine(array[count]);
            n = n /10;
        }
        
        if (array[0] == array[4])
        {
            if(array[1] == array[3])
                {
                    Console.WriteLine("Число палиндром");
                }
            else 
            {
                Console.WriteLine("Число не палиндром");
            }
        }
        else
        {
        Console.WriteLine("Число не палиндром");
        }
        return array;
    }

Console.WriteLine("Введите пятизначное число, проверим является оно палиндромом?");
int number = int.Parse(Console.ReadLine()!);
inputArray(number);