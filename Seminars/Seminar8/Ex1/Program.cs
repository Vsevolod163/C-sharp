// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.
// Аргументы индексы

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
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

int[,] ChangePositions(int[,] array, int row1, int row2)
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

Console.Write("Введите номер строки 1: ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки 2: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(5, 7, 0, 10);
Print2DArray(array);

if(row1 > array.GetLength(0) - 1 || row2 > array.GetLength(0) - 1) Console.WriteLine("Невозможно");
else
{
    ChangePositions(array, row1, row2);
    Print2DArray(array);
}


