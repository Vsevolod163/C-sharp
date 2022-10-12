// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

int Max(int n1, int n2, int n3)
{
    int max = n1;
    if(n2 > max ) max = n2;
    if(n3 > max) max = n3;
    return max;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int res = Max(num1, num2, num3);
Console.WriteLine($"Максимальное из трех чисел: {res}");