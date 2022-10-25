//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
//Напишите программу, которая принимает на вход координаты двух точек 
Console.WriteLine("Поиск расстояния между точками");
Console.WriteLine("Введите координаты точки А (х,y,z)");
int xA = int.Parse(Console.ReadLine()!);
int yA = int.Parse(Console.ReadLine()!);
int zA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B (х,y,z)");
int xB = int.Parse(Console.ReadLine()!);
int yB = int.Parse(Console.ReadLine()!);
int zB = int.Parse(Console.ReadLine()!);
//и находит расстояние между ними в 3D пространстве.
double Length(int xA, int yA, int zA, int xB, int yB, int zB)
{
double result = 0;
result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2)+ Math.Pow((zB - zA), 2));
return result;
}

Console.WriteLine("Расстояние между точками " + Length(xA, yA, zA, xB, yB, zB));