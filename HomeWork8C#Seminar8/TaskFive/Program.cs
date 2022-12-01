/* Напишите программу, которая заполнит спирально массив 4 на 4..
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int [,] matrix = new int[,]
{
    {0,0,0,0},
    {0,0,0,0},
    {0,0,0,0},
    {0,0,0,0}
};
void SpiralFillArray(int[,] mas)
{
    int number = 1;
    int gorizont = 4;
    int vertical = 4;
    int ig = 0;
    int iv = 0;
    int jg = 0;
    int jv = 0;
    int i = 0;
    int j = 0;
    while (number <= gorizont*vertical)
        {
            mas[i,j] = number;
        if (i == ig && j < vertical - jv - 1)
            {j++;}
        else if (j == vertical - jv -1 && i < gorizont - iv - 1)
            {i++;}
        else if (i == gorizont - iv - 1 && j > jg)
            {j--;}
        else {i--;}

        if ((i == ig + 1) && (j == jg) && (jg != vertical - jv - 1))
            {
                ig++;
                iv++;
                jg++;
                jv++;
            }
            number++;
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
SpiralFillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
