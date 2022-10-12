// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

int[] Rerverse(int[] array)
{
    int l = array.Length;
    for(int i = 0, j = 1; i < l - j; i++, j++)
    {
        int temp = array[i];
        array[i] = array[l - j];
        array[l - j] = temp;
    }

    return array;
}

Console.Write("Массив: ");
int[] array = RandomArray(12, -15, 17);
PrintArray(array);
Rerverse(array);
Console.Write("Перевернутый массив: ");
PrintArray(array);