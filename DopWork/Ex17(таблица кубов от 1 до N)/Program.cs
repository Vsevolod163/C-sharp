// Напишите программу, которая на вход принимает число N и выдает таблицу кубов чисел от 1 до N

void Cub(int n)
{
    for(int i = 1; i <= n; i++)
    {
        int res = i * i * i;
        Console.Write($"{res} ");
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица кубов от 1 до {N}: ");
Cub(N);
