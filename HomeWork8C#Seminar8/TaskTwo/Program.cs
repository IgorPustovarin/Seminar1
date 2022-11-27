/*  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int [,] matrix = new int[,]
{
    {111,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};
void Result(int[,] mas)
{
int[] array = new int[4];
int sum = 0;
int minNumderSum = 555555;
int numberStroki = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sum = sum + mas[i,j];
        }
    if (sum < minNumderSum)
        {
            minNumderSum = sum;
            numberStroki = i;
        }
    sum = 0;
    }
    Console.Write($"Минимальная сумма в строке {numberStroki} ");
}
void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
    Console.WriteLine();
    }
}

PrintArray(matrix);
Console.WriteLine();
Result(matrix);