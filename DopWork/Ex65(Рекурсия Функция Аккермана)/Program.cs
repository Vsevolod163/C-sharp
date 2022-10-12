// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int SumAkkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(n == 0) return SumAkkerman(m - 1, 1);
    if(m != 0 && n != 0) return SumAkkerman(m - 1, SumAkkerman(m, n - 1));
    
    return 0;
}

Console.Write($"Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

while(M < 0 || N < 0)
{
    Console.WriteLine("Введите неотрицательные значения M и N:");
    Console.Write($"Введите значение M: ");
    M = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Введите значение N: ");
    N = Convert.ToInt32(Console.ReadLine());
}

int sum = SumAkkerman(M, N);
Console.Write($"A({M},{N}) = {sum}");