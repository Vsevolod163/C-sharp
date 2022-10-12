/* Задача 64: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 5, 6, 7, 8""

void Numbers(int M, int N)
{
    if(N > M) Numbers(M, N - 1);
    
    if(M > N) Numbers(M, N + 1);
    Console.Write(N + " ");
}

Numbers(1, 5);

// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfElements(int M, int N)
{
    if(M < N) return M + SumOfElements(M + 1, N);
    if(M > N) return M + SumOfElements(M - 1, N);
    return N;
}

Console.Write($"Введите натуральное значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите натуральное значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = SumOfElements(M, N);
Console.WriteLine($"Сумма элементов от M до N = {sum}");

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

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
*/