//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Впишите число");
int numberA = int.Parse(Console.ReadLine()!);
int SearchTreeNumber(int numberA)
{  
if(numberA > 99)
    {
        
        while (numberA > 1000)
        numberA = numberA / 10;
        {
            int numberB = numberA % 10;
            return numberB;
        }
    }
else Console.WriteLine("Третья цифра в числе отсутствует");
return numberA;
}

int numberC = SearchTreeNumber(numberA);

Console.WriteLine(numberC);