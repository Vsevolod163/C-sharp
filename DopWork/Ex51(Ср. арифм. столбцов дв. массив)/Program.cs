// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArray(rows, columns, min, max);

Console.WriteLine();
Print2DArray(array);

Console.WriteLine($"Среднее арифметическое каждого столбца = {AverageValue(array)}");