// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
double[] ArrayNumbers()
{
var result = new double[6];

Random random = new();

for (int i = 0; i < result.Length; i++)
{
result[i] = random.NextDouble() * 100;
}

return result;
}

void Print(double[] input)
{
for (int i = 0; i < input.Length; i++)
{
Console.Write(input[i].ToString("0.###"));

if (i != input.Length - 1)
Console.Write(", ");
}
Console.WriteLine();
}

double FindingTheDifference(double[] input)
{
double result = 0;
double max = 0;
double min = 0;
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
Console.WriteLine("Максимальный элемент: " + max.ToString("0.###"));
Console.WriteLine("Минимальный элемент: " + min.ToString("0.###"));
result = max - min;
return result;
}

var array = ArrayNumbers();
Print(array);
var Difference = FindingTheDifference(array);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + Difference.ToString("0.###"));

//var Difference = FindingTheDifference(array);
//Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + Difference);
