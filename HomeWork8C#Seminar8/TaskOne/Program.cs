// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] matrix = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};
void SortNumber(int[,] mas)
{
    int temp=0;
    for (int i=0; i < mas.GetLength(0); i++)
    {
        for (int j=0; j < mas.GetLength(1); j++)
        {
            for (int a = 0; a < mas.GetLength(1)-1; a++)
            {
                if (mas[i,a] < mas[i, a+1])
                {
                    temp = mas[i,a];
                    mas[i, a] = mas[i,a+1];
                    mas[i, a+1] = temp;
                }
                
            }
        }
    }
}

void PrintArray(int[,] mas)
{
    for (int i =0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i,j]} ");
        }
    Console.WriteLine();
    }
}
PrintArray(matrix);
SortNumber(matrix);
Console.WriteLine();
PrintArray(matrix);