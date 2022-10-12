/* Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.(Не через массив)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int Quant(int M)
{
    int count = 0;
    for(int i = 1; i <= M; i++)
    {
        Console.Write($"Введите число {i}: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n > 0) count++;
    }

    return count;
}

Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int result = Quant(M);
Console.WriteLine($"Количество чисел больше 0, которые ввел пользователь = {result}");

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string Point(double b1, double k1, double b2, double k2)
{
    string result = String.Empty;

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    result = $"({x}; {y})";

    return result;
}

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

string result = Point(b1, k1, b2, k2);

Console.WriteLine($"Точка пересечения двух прямых: {result}");
*/