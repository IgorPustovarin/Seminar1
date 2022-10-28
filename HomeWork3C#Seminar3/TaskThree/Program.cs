// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

int[] mathArray(int n)
    {
        int[] array = new int[n];
        for (int count = 0; count < n; count++)
        {
            array[count] = (count + 1) * (count + 1) * (count + 1);
            Console.Write($"{array[count]}, ");
        }
        return array;
    }
Console.WriteLine("Введите число, выведу числа от 1 до введенного числа в кубе в кубе");
int number = int.Parse(Console.ReadLine()!);
mathArray(number);
