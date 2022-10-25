//Напишите программу, которая принимает на вход пятизначное число 
Console.WriteLine("Проверка является ли пятизначное число палиндромом");
Console.WriteLine("Впишите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
int проверкаПалиндромов()
{
    int numberA = number / 10000;
    int numberB = number / 1000 % 10;
    int numberC = number % 100 / 10;
    int numberD = number % 10;
    if(number > 9999)
        if(number < 100000)
                if(numberA == numberD)
                    if(numberB == numberC)
                    return 2;
    return 1;
}
//и проверяет, является ли оно палиндромом. Через строку решать нельзя.
int result = проверкаПалиндромов();
if(result == 1)
Console.WriteLine("Нет");
if(result == 2)
Console.WriteLine("Да");
//14212 -> нет

//12821 -> да

//23432 -> да