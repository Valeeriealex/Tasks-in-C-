// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 16.58
//A (7,-5, 0); B (1,-1,9) -> 11.53

//Math.Sqrt(56);
//Math.Pow (2,10);

//double d = 5.09997676;
//double resD = Math.Round (d, 2);
//MidpointRounding.ToZero;
//System.Console.WriteLine (resD);

Console.WriteLine ("Введите координаты точки x точки A");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки y точки A");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки z точки A");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки x точки B");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки y точки B");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты точки z точки B");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Distance (xa, ya, za, xb, yb, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние от A до B {distance}");

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
  return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
}