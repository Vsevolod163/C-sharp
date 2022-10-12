// Развернуть массив (Необязательно выводить каждый раз массив, метод PrintArray сделает это в следующих случаях (строка 29 выводит перевернутый массив))

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Reverse(int[] array)
{
    int l = array.Length;
    for(int i = 0; i < l; i++)
    {
        l = l - 1;
        int temp = array[i];
        array[i] = array[l];
        array[l] = temp;
    }
}

int[] arr = {5, 92, 51, 25, 633, 42, 7};
Console.Write("Массив: ");
PrintArray(arr);
Console.Write("Перевернутый массив: ");
Reverse(arr);
PrintArray(arr);