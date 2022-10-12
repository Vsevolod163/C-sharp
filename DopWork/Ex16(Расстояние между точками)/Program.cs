// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double Pif(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return res;
}

Console.WriteLine("Введите координаты точки A: ");
Console.Write("x1 = ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("x2 = ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
int Z2 = Convert.ToInt32(Console.ReadLine());
double result = Pif(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine($"Расстояние мужду точками = {result}");