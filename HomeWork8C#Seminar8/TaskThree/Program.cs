// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int [,] matrix1 = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

void CompositionMatrix(int[,] mas)
{
    int [,] matrix2 = new int[,]
    {
        {2,2,2,2},
        {2,2,2,2},
        {2,2,2,2}
    };
    for (int i=0; i < mas.GetLength(0); i++)
    {
        for (int j=0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = mas[i,j] * matrix2[i,j];
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
PrintArray(matrix1);
CompositionMatrix(matrix1);
Console.WriteLine();
PrintArray(matrix1);
