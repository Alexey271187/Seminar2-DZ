// Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
Console.WriteLine("Введите число до 10:");
int a = int.Parse(Console.ReadLine()!);
int [,] numbers = new int [5,5];

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    Console.WriteLine(); 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }   
        Console.WriteLine(); 
    }
}
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
void PrintResult(int[,] array)
{
    Console.WriteLine(); 
    Console.WriteLine($"Число {a} находится по следующим координатам: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a == array[i,j])
            Console.Write($"строка {i+1} позиция {j+1}, ");            
        } 
        
    }
    Console.WriteLine("или отсутствует в массиве.");
}

FillArrayRandom(numbers);
PrintArray(numbers);
PrintResult(numbers);
