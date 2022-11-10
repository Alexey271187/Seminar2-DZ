// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

//452 -> 11

//82 -> 10

//9012 -> 12

int СуммаЦифрВЧисле (int number)
{
    int result = 0;
    int numberA = 0;
    while (number >= 1)
    {
    numberA = number % 10;
    result = result + numberA;
    number = number / 10;
    }
    
    return result;
}

Console.WriteLine("Программа для поиска суммы цифр в числе");
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int result = СуммаЦифрВЧисле(number);
Console.WriteLine("Сумма цифр " + result);