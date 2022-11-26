// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]:F2} ");
        }
    Console.WriteLine();
    }
}
void FillArray(double[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = new Random().NextDouble() * 100;
        
        }
    }
}
double[,] matrix = new double [4, 4];
FillArray(matrix);
PrintArray(matrix);