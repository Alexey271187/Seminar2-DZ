// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.0,111000

Console.WriteLine("Программа, которая задаёт массив из 8 целых чисел с клавиатуры");
Console.WriteLine("Введите числа, после каждого числа нажмите Enter: ");

int[] GetSqrtTable()
{
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
array[i] = int.Parse(Console.ReadLine()!);
return array;
}
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
Console.Write($"{array[i]},");
}

int[] array = GetSqrtTable();
PrintArray(array);
//Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}");
