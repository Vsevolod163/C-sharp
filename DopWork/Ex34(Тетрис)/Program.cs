// Игра тетрис

// int[,] tet = new int[2, 5];

// for(int i = 0; i < tet.GetLength(0); i++)
// {
//     for(int j = 0; j < tet.GetLength(1); j++)
//     {
//         Console.Write($"{tet[i, j]} ");
//     }
//     Console.WriteLine();
// }

int[,] RandomDvArray(int row, int col, int MinEl, int MaxEl)
{
    int[,] array = new int[row, col];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(MinEl, MaxEl + 1);
        }
    }
    
    return array;
}

int[,] Osn(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0 || j == array.GetLength(1) - 1 || i == array.GetLength(0) - 1) array[i, j] = 1;
        }
    }
    
    return array;
}

int[,] Square(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j >= 1 && j <= 5 && i >= 0 && i <= 2) array[i, j] = 1;
        }
    }

    return array;
}

void FillImage(int[,] array, int row, int col)
{
    for(int i = 1; i <= row; i++)
    {
        for(int j = 1; j <= col; j++)
        {
            if(j >= 1 && j <= 5 && i >= 0 && i <= 2) array[i, j] = 1;
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }    
}
void PrintArrayTet(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == 1) Console.Write("+ ");
            else Console.Write($"  ");
        }
    Console.WriteLine();
    }
}

int[,] array = RandomDvArray(25, 50, 0, 0);
PrintArray(array);
Console.WriteLine();
Osn(array);
Square(array);
PrintArrayTet(array);

