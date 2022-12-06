/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] arrayWords = {"hello", "2", "world", ";-)"};

void SortArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    int n = 0;
    string[] newArray = {};
    if (array[i].Length <= 3)
        {
            n++;
            Array.Resize(ref newArray, n);
            newArray[n-1] = array[i];            
            Console.WriteLine($"{newArray[n-1]}");
        }
    }

}
SortArray(arrayWords);