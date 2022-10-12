// Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов 
//массива, значения которых лежат в отрезке [10,99].

int[] RandomArray(int size, int MinEl, int MaxEl)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) array[i] = new Random().Next(MinEl, MaxEl + 1);
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int Count(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) sum ++;
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент: ");
int MinEl = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент: ");
int MaxEl = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(size, MinEl, MaxEl);
Console.Write("Массив: ");
PrintArray(array);

int count = Count(array);
Console.Write($"Количество элементов в отрезке [10, 99] = {count}");