int max = new Random().Next(10, 99);
Console.WriteLine("Получаем случайное число: ");
Console.WriteLine(max);
int GetFirstDigit(int max)
{
    int number1 = max / 10;
    return number1;
}
int Get2Digit(int max)
{
    int number2 = max % 10;
    return number2;
}
if (GetFirstDigit(max)>Get2Digit(max)) Console.WriteLine(GetFirstDigit(max));
if (GetFirstDigit(max)<=Get2Digit(max)) Console.WriteLine(Get2Digit(max));
