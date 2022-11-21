// Задайте двумерный массив из целых чисел. 

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

//Найдите среднее арифметическое элементов в каждом столбце.
void PrintResult(int[,] array)
{   
    //Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
    double result = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        result = (result + numbers[i, j]);
    }
    result = result / strings;
    Console.WriteLine($"Cреднее арифметическое элементов в столбце {j+1} равно {result}.");
    }
}


FillArrayRandom(numbers);
PrintArray(numbers);
PrintResult(numbers);