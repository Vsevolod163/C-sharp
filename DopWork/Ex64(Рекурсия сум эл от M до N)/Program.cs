// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfElements(int M, int N)
{
    if(M < N) return M + SumOfElements(M + 1, N);
    if(M > N) return M + SumOfElements(M - 1, N);
    return N;
}

Console.Write($"Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = SumOfElements(M, N);
Console.WriteLine($"Сумма элементов от M до N = {sum}");