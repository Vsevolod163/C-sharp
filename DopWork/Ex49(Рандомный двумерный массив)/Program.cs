// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandomArray(rows, columns, min, max);

Print2DArray(array);