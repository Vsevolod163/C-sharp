// Task 2 Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int ShowQuart(int x, int y)
{
    int temp = 0;
    while(x == 0 || y == 0)
    {
        Console.Write("The point is on the axis! Try again: ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
    }
    if(x > 0 && y > 0) temp++;
    if(x < 0 && y > 0) temp += 2;
    if(x < 0 && y < 0) temp += 3;
    if(x > 0 && y < 0) temp += 4;
    return temp;
}

Console.Write("Input x: ");
int coordinateX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int coordinateY = Convert.ToInt32(Console.ReadLine());

int numbquart = ShowQuart(coordinateX, coordinateY);
Console.Write ("Данная точка в четверти " + numbquart);