// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк");
int strings = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);

void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(0, 10));
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] numbers = new double[strings, columns];
FillArrayRandom(numbers);
PrintArray(numbers);
