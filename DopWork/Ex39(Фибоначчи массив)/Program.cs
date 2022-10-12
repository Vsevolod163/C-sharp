// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Первые два числа будут аргументами (Три аргумента: колич чисел, 1 число, 2 число)

int[] InputArray(int size, int x1, int x2)
{
    int[] array = new int[size];
    array[0] = x1;
    array[1] = x2;
    for(int i = 2; i < size; i++)
    {
        int x3 = x1 + x2;
        array[i] = x3;
        x1 = x2;
        x2 = x3;
    }
    
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

Console.Write("Введите количество элементов, включая первые два элемента: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первый элемент: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второй элемент: ");
int x2 = Convert.ToInt32(Console.ReadLine());

int[] array = InputArray(size, x1, x2);
Console.Write($"Последовательность Фибоначчи, в которой первые два числа {x1}, {x2}, а общее количество = {size}: ");
PrintArray(array);
