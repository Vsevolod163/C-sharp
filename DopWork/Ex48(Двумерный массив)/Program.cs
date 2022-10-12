// Задать двумерный массив

int[,] InputArray(int row, int col, int MinEl, int MaxEl)
{
    Random rand = new Random();
    int[,] array = new int[row, col];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) array[i, j] = rand.Next(MinEl, MaxEl + 1);
    }

    return array;
}


int[,] ReverseArrayRows(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0, k = 1; j < array.GetLength(1) - k; j++, k++) 
        {
            int temp = array[i, j];
            array[i, j] = array[i, array.GetLength(1) - k];
            array[i, array.GetLength(1) - k] = temp;
        }
    }

    return array;
}

int[,] ReverseArrayColumns(int[,] array)
{
    for(int i = 0, k = 1; i < array.GetLength(0) - k; i++, k++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            int temp = array[i, j];
            array[i, j] = array[array.GetLength(0) - k, j];
            array[array.GetLength(0) - k, j] = temp;
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = InputArray(4, 4, -9, 9);
Console.WriteLine();
Console.WriteLine("Массив:");
PrintArray(array);
ReverseArrayRows(array);
Console.WriteLine("Массив с перевернутыми строками:");
PrintArray(array);
ReverseArrayColumns(array);
Console.WriteLine("Массив с перевернутыми столбцами:");
PrintArray(array);