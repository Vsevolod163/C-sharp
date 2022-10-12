//  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void ShowDiaposon(int quart)
{
    while(quart < 1 || quart > 4)
    {
        Console.Write("Uncorrect input! Try again here: ");
        quart = Convert.ToInt32(Console.ReadLine());
    }
    
    if(quart == 1) Console.WriteLine("x > 0, y > 0");
    if(quart == 2) Console.WriteLine("x < 0, y > 0");
    if(quart == 3) Console.WriteLine("x < 0, y < 0");
    if(quart == 4) Console.WriteLine("x > 0, y < 0");
}

Console.Write("Input number of quart: ");
int quartNum = Convert.ToInt32(Console.ReadLine());

ShowDiaposon(quartNum);

