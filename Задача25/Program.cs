//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int ВозводитВНатуральнуюСтепень (int numberA, int numberB)
{
    int result = 1;
    int count = 0;
    while (count < numberB)
    {
        result = result * numberA;
        count++;
    }
    return result;
}

Console.WriteLine("Программа для возводения числа A в натуральную степень B");
Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В");
int numberB = int.Parse(Console.ReadLine()!);
int result = ВозводитВНатуральнуюСтепень(numberA, numberB);
Console.WriteLine("Получится " + result);