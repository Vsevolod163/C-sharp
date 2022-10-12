// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int Sum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) count += array[i];
    }
    return count;
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

int count = Sum(array);
Console.Write($"Сумма элементов, стоящих на нечетных позициях = {count}");