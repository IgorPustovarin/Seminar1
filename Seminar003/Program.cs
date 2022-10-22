// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void Diapazon(int numberPlace)
{
   if (numberPlace == 1) Console.WriteLine("Координаты могут быть расположен в диапазоне +X, +Y");
   else if (numberPlace == 2) Console.WriteLine("Координаты могут быть расположен в диапазоне +X, -Y");
   else if (numberPlace == 3) Console.WriteLine("Координаты могут быть расположен в диапазоне -X, -Y");
   else if (numberPlace == 4) Console.WriteLine("Координаты могут быть расположен в диапазоне -X, +Y");
}
Console.WriteLine("Введите номер плоскости ");
int numberPlace = int.Parse(Console.ReadLine()!);
Diapazon (numberPlace);