/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
Например при значениях b1 = 2, k1 = 5, b2 = 4, k2 = 9 Ответ: (-0,5; -0,5)
*/
Console.WriteLine("Введите b1");
float b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
float k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
float b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
float k2 = int.Parse(Console.ReadLine()!);

float x = 0;
float y = 0;
if (k1 == k2)
    {
        Console.WriteLine("прямые параллельны, точка пересечения отсутствует");
    }
else
    {
        x = (b2 - b1)/(k1 - k2);
        y = k1*x +b1;
    }
 Console.WriteLine($"Координаты пересечения прямых X = {x}, Y = {y}");