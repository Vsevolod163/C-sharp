// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int Chet(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }

    return count;
}

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(size, 100, 999);
Console.Write("Массив: ");
PrintArray(array);

int count = Chet(array);
Console.Write($"Количество четных элементов в массиве = {count}");