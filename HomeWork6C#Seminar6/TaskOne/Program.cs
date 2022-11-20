// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Сколько чисел планируте ввести?");
int quantity = int.Parse(Console.ReadLine()!);
int countPositiveNumbers = 0;
for (int i = 0; i < quantity; i++)
    {
        Console.WriteLine("Вводите числа чечез Enter");
        int number = int.Parse(Console.ReadLine()!);
        if (number > 0)
        {
            countPositiveNumbers++;
        }
    }
Console.WriteLine($"Количество положительных чисел {countPositiveNumbers}");