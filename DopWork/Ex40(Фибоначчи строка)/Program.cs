// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Первые два числа будут аргументами (Три аргумента: колич чисел, 1 число, 2 число)

string Fibonachi(int size, int x1, int x2)
{
    string result = $"{x1} {x2}";
    for(int i = 2, x3 = 0; i < size; i++)
    {
        x3 = x1 + x2;
        result = $"{result} {x3}";
        x1 = x2;
        x2 = x3;
    } 

    return result;
}

Console.Write("Введите количество элементов, включая первые два элемента: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первый элемент: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второй элемент: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ряд Фибоначчи: {Fibonachi(size, x1, x2)}");