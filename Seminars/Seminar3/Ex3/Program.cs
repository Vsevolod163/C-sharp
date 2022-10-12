// Task 3 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double distance (int x1, int y1, int x2, int y2)
{
    double Pif = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return Pif;
}

Console.Write("Input x1: ");
int coordinateX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int coordinateY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int coordinateX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int coordinateY2 = Convert.ToInt32(Console.ReadLine());


double Distance = distance(coordinateX1, coordinateX2, coordinateY1, coordinateY2);
Console.Write("The distanse is " + Distance);