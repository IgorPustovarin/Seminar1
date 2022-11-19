// Дан массив чисел.
//Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем.
// При отсутствии числа возвращать -1.


void Search(int numberSearch)
{
    int idSearch = -1;
    int [] array = new int[4] {3, 5, 7, 8};
    for (int count = 0; count < 4; count++)
    {
        if (array[count] == numberSearch)
        {
        idSearch++;
        Console.WriteLine($"Элемент расположен под индексом {count}");
        }
    }
    if (idSearch == -1) Console.WriteLine(-1);
}
Console.WriteLine("Введитечисло для поиска");
int numberSearch = int.Parse(Console.ReadLine()!);
Search (numberSearch);
