// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
int[] ArrayNumbers()
{
var result = new int[6];

Random random = new();

for (int i = 0; i < result.Length; i++)
{
result[i] = random.Next(1,99);
}

return result;
}

void Print(int[] input)
{
for (int i = 0; i < input.Length; i++)
{
Console.Write(input[i]);

if (i != input.Length - 1)
Console.Write(", ");
}
Console.WriteLine();
}

int FindingTheDifference(int[] input)
{
int result = 0;
int max = 0;
int min = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] > max)
    {
        max = input[i];
        min = max;
    } 
}
for (int i = 0; i < input.Length; i++)
{
    if (input[i] < min)
    {
        min = input[i];
    } 
}
Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Минимальный элемент: " + min);
result = max - min;
return result;
}

var array = ArrayNumbers();
Print(array);

var Difference = FindingTheDifference(array);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + Difference);
