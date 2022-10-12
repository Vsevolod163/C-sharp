// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Первые два числа будут аргументами (Три аргумента: колич чисел, 1 число, 2 число)

// 0, 1, 1 , 2, 3, 5, 8, 13  N = (N - 1) + (N - 2)
// 2 , 3  N = 5
string fib(int N, int x1, int x2)
{
    string result = $"{x1} {x2} ";
    for(int i = 2; i < N; i++)
    {
        int x3 = x1 + x2;
        result += x3 + " ";
        x1 = x2;
        x2 = x3;
    }
    
    return result;
}

Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 1 элемент: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 элемент: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат: {fib(n, x1, x2)}");
