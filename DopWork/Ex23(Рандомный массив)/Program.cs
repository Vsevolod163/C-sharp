// Написать программу, которая выводит рандомный массив, числа задаются пользователем

int[] RandomArray(int size, int MinElement, int MaxElement)
{
    int[] NewArray = new int[size];
    for(int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = new Random().Next(MinElement, MaxElement);
    }
    return NewArray;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}

Console.Write("Input size: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Min Element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Max Element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] Array = RandomArray(s, min, max);
PrintArray(Array);