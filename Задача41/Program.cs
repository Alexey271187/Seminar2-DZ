Console.WriteLine("Программа считает сколько чисел больше 0 вы ввели");
//Пользователь вводит с клавиатуры M чисел. 
Console.WriteLine("Сколько всего чисел желаете ввести:");
int number = int.Parse(Console.ReadLine()!);

int[] FormArray()
{
Console.WriteLine("Введите любые числа, после каждого числа нажмите Enter: ");
int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
array[i] = int.Parse(Console.ReadLine()!);
return array;
}
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
int CheckingArray(int[] array)
{
int result = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
    result = result + 1;
    return result;

}

int[] array = FormArray();
Console.Write("Колличество чисел больше 0 равно: ");
Console.WriteLine(CheckingArray(array)) ;
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3 Тут ошибка в условии!!