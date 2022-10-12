/* Task 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    Random rand = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) 
        {
            array[i, j] = rand.NextDouble() + rand.Next(minValue, maxValue + 1);
            array[i, j] = Math.Round(array[i, j], 2);
            // array[i, j] = array[i, j] - array[i, j] % 0.01;
        }
    }

    return array;
}

void Print2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите необходимое количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите необходимое количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandomArray(rows, columns, min, max);

Print2DArray(array);

// Task 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// array [1, 7] -> такого числа в массиве нет

int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rand = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) array[i, j] = rand.Next(minValue, maxValue + 1);
    }

    return array;
}

string FindNumber(int row, int col, int[,] array)
{
    if(row < array.GetLength(0) && col < array.GetLength(1)) return Convert.ToString(array[row, col]);
    else return "Такого числа нет в массиве";
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

Console.Write("Введите необходимое количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите необходимое количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArray(rows, columns, min, max);

Console.WriteLine();
Print2DArray(array);

Console.Write("Введите номер строки элемента: ");
int numberRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца элемента: ");
int numberCol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write($"Значение элемента: {FindNumber(numberRow, numberCol, array)}");

// Task 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rand = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) array[i, j] = rand.Next(minValue, maxValue + 1);
    }

    return array;
}

string AverageValue(int[,] array)
{
    double temp = 0;
    string result = String.Empty;

    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = 0;
        for(int i = 0; i < array.GetLength(0); i++) 
        {
            temp += array[i, j];
        }
        temp /= array.GetLength(0);
        temp = Math.Round(temp, 2);
        result += Convert.ToString(temp) + ";" + " ";
    }

    return result;
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

Console.Write("Введите необходимое количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите необходимое количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArray(rows, columns, min, max);

Console.WriteLine();
Print2DArray(array);

Console.WriteLine($"Среднее арифметическое каждого столбца = {AverageValue(array)}");
*/