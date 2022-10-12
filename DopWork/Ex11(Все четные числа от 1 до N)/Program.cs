// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

void Chet(int n)
{
    for(int i = 1; i <= n; i++)
    {
        if(i % 2 == 0) Console.Write($"{i} ");
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Все четные числа от 1 до {num}: ");
Chet(num);
