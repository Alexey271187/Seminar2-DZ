// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);


int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {CountNaturalSum(m, n)}");