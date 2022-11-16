// Задайте массив заполненный случайными положительными трёхзначными числами. 
int[] ArrayOfRandomNumbers(int numbers = 7, int startInterval = 100, int endInterval = 999)
{
var result = new int[numbers];

Random random = new();

for (int i = 0; i < numbers; i++)
{
result[i] = random.Next(startInterval, endInterval + 1);
}

return result;
}
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

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

int FindingEvenNumbers(int[] input)
{
int result = 0;
for (int i = 0; i < input.Length; i++)
{
if (input[i] % 2 == 0)
    {
    Console.WriteLine("+");
    result = result + 1;
    }
else
Console.WriteLine("-");   
}
return result;
}



var array = ArrayOfRandomNumbers();
Print(array);

var EvenNumbers = FindingEvenNumbers(array);
Console.WriteLine("Четных чисел в массиве: " + EvenNumbers);

