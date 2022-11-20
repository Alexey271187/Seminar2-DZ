// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Программа для поиска точки пересечения двух прямых");
Console.WriteLine("введите значение b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите число k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите число k2");
double k2 = double.Parse(Console.ReadLine()!);
// Метод вычисления точки пересечения.
double x = (-b2 + b1)/(-k1 + k2);
double y = k1 * x + b1;
//double y = k2 * x + b2;
Console.Write("Две прямые пересекутся в точке: ");
Console.WriteLine($"X: {x}, Y: {y}");
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)