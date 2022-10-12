// Написать радомный двумерный массив вещественных чисел

double[,] RandDvArray(int row, int col, int MinEl, int MaxEl)
{
    double[,] array = new double[row, col];
    Random rand = new Random(); 
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble() + rand.Next(MinEl, MaxEl + 1);
        }
    }

    return array;
}

void PrintDvArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] array = RandDvArray(5, 3, -12, 17);
PrintDvArray(array);
