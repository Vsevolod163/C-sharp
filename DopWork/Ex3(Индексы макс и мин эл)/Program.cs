// Нахождение индексов максимального и минимального элемента массива

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int MaxEl(int[] array)
{
    int max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > array[max]) max = i;
    }
    return max;
}

int MinEl(int[] array)
{
    int min = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[min]) min = i;
    }
    return min;
}

int[] arr = {153, 65, 132, 36, 57, 1359};
PrintArray(arr);
int maximum = MaxEl(arr);
int minimum = MinEl(arr);
Console.WriteLine($"Индекс минимального элемента = {minimum};"); 
Console.WriteLine($"Индекс максимального элемента = {maximum};");
