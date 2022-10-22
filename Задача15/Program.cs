//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Впишите цифру, обозначающую день недели");
int numberA = int.Parse(Console.ReadLine()!);
int чипслонедели()
{
    if(numberA > 7)
    return 1;
        if(numberA <= 5)
        {
        return 2;
        }
        else 
        return 3;
}

int numberB = чипслонедели();
if(numberB == 1)
Console.WriteLine("Неверное значение");
if(numberB == 2)
Console.WriteLine("будний");
if(numberB ==3)
Console.WriteLine("выходной");