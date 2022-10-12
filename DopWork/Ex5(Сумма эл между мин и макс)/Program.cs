// Найти сумму элементов массива между минимальным и максимальным элементами 
// (если есть несколько минимальных и максимальных, то будет считать от крайнего к последнему ( смотреть знаки в 15 и 25 строках))

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int MinEl(int[] arr)
{
    int min = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < arr[min]) min = i;
    }
    return min;
}

int MaxEl(int[] arr)
{
    int max = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= arr[max]) max = i;
    }
    return max;
}

int[] array = {5, 2, 15, 675, 2, 35, 11, 754, 985, 7, 985, 875};
PrintArray(array);
int min = MinEl(array);
int max = MaxEl(array);
Console.WriteLine($"Минимальный элемент = {array[min]}");
Console.WriteLine($"Максимальный элемент = {array[max]}");

int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    if(i >= min && i <= max) sum = sum + array[i];
}

Console.WriteLine($"Сумма элементов массива между минимальным и максимальным = {sum}");
