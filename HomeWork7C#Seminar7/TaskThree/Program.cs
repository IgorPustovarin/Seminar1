/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
double [,] matrix = new double[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};
void Result(double[,] mas)
{
double[] array = new double[4];
double sum = 0;
    for (int i = 0; i < mas.GetLength(1); i++)
    {
        for (int j = 0; j < mas.GetLength(0); j++)
        {
            sum = sum + mas[j,i];
        }
    array[i] = sum/(mas.GetLength(0));
    Console.Write($"{array[i]:F2} ");
    sum = 0;
    }
}
void PrintArray(double[,] mas)
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


