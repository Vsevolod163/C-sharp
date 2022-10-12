// Найти среднее арифметическое всех элементов массива ( В вывод можно записывать интовый метод)

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int SumAll(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] array = {5, 10, 52, 15, 95, 5, 15};
Console.Write("Массив: ");
PrintArray(array);
int summa = SumAll(array);
Console.WriteLine($"Сумма всех элементов массива: {summa}");