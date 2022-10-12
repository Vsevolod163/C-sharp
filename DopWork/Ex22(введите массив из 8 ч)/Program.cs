// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] InputArray(int size)
{
    int[] NewArray = new int[size];
    Console.WriteLine("Input elemets of Array");
    for(int i = 0, k = 1; i < NewArray.Length; i++, k++)
    {
        Console.Write($"Input n{k}: ");
        int n = Convert.ToInt32(Console.ReadLine());
        NewArray[i] = n;
    }
    return NewArray;
}

void PrintArray(int[] array)
{
    int i = array.Length - 1;
    Console.Write("[");
    for(i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[i]}]");
}

Console.Write("Input Array Size: ");
int s = Convert.ToInt32(Console.ReadLine());
int[] res = InputArray(s);
Console.Write("Array: ");
PrintArray(res);
