// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.
// Аргументы индексы

int[,] Create2DArray(int rows, int columns, int minEl, int maxEl)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) array[i, j] = new Random().Next(minEl, maxEl + 1);
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeRows(int[,] array, int row1, int row2)
{
    int temp = 0;
   
    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = temp; 
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

Console.Write("Введите номер строки 1: ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки 2: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DArray(rows, columns, min, max);
Print2DArray(array);

if(row1 >= rows || row2 >= columns) Console.WriteLine("Невозможно выполнить операцию");
else
{
    int[,] newArray = ChangeRows(array, row1, row2);
    Print2DArray(newArray);
}