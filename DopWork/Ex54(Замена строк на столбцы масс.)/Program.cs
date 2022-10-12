// Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.

int[,] CreateRandomArray(int rows, int columns, int minEl, int maxEl)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) array[i, j] = new Random().Next(minEl, maxEl + 1);
    }

    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ReverseArray(int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }

    return array;
}

Console.Write("Введите необходимое количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите необходимое количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArray(rows, columns, min, max);
PrintArray(array);
if(rows < columns || columns < rows) Console.WriteLine("Невозможно выполнить данную операцию");
else
{
    int[,] result = ReverseArray(array);
    PrintArray(result);
}