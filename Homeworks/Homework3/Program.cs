/* Task1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

void Polindrom(int n)
{
    while(n > 100000 || n < -100000 || n < 10000 && n > -10000) 
    {   
        Console.Write("Ошибка. Введите число еще раз: ");
        n = Convert.ToInt32(Console.ReadLine());
    }    
        int z = n / 10000;
        int k = (n / 1000) % 10;
        if(z == (n % 10) && k == ((n / 10) % 10)) Console.Write("Является ли число палиндромом? Да");
          
        else Console.Write("Является ли число палиндромом? Нет");          
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Polindrom(num);

// Task2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double pif = Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1) + (z2 - z1) * (z2 - z1));
    return pif;    
}

Console.WriteLine("Введите координаты точки A: ");
Console.Write("Введите x1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите координаты точки B: ");
Console.Write("Введите x2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine());

double res = distance(X1, Y1, Z1, X2, Y2, Z2);
Console.Write($"Расстояние между точками = {res}");

// Task 3 Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

void cub(int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++) 
    {
        result = i * i * i;
        Console.Write($"{result} ");
    }   
}

Console.Write($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Результат: ");
cub(num);
*/