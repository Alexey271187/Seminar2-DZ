// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int[] ArrayOfRandomNumbers()
{
var result = new int[4];

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

int FindingNotEvenPosition(int[] input)
{
int result = 0;
for (int i = 0; i < input.Length; i++)
{
if (i % 2 != 0)
    {
    Console.WriteLine("+");
    result = result + input[i];
    }
else
Console.WriteLine("-");   
}
return result;
}


var array = ArrayOfRandomNumbers();
Print(array);

var NotEvenPosition = FindingNotEvenPosition(array);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + NotEvenPosition);