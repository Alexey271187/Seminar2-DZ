Console.WriteLine("Введите количество строк");
int strings = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);
int[,] numbers = new int[strings, columns];


void FillArrayRandom(int[,] array) 
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
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

//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void MinStringSumElements(int[,] array)
{
    int minString = 0;
    int minSumString = 0;
    int sumString = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minString += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumString += array[i, j];
        if (sumString < minString)
        {
            minString = sumString;
            minSumString = i;
        }
        sumString = 0;
    }
    Console.WriteLine($"В строке {minSumString + 1} наименьшая сумма элементов");
}

FillArrayRandom(numbers);
if (strings != columns) // Задайте прямоугольный двумерный массив. 
{
    PrintArray(numbers);
    MinStringSumElements(numbers);
}
else Console.WriteLine("Количество строк и столбцов должно быть разным!");
