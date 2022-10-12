//  Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SpiralArray(int n, int n1)
{
    int[,] array = new int[n, n1];
    int j = 0;
    for(int resultNumber = 1, zeroValue = 0, lastElementRow = n - 1, lastElementCol = n1 - 1; resultNumber <= n * n1; zeroValue++, lastElementRow--, lastElementCol--)
    {
        // Вправо
        for(j = zeroValue; j <= lastElementCol; j++) array[zeroValue, j] = resultNumber++;
        if(array[zeroValue, j - 1] == n * n1) break;
        // Вниз
        for(int i = zeroValue + 1; i <= lastElementRow; i++) array[i, lastElementCol] = resultNumber++;
        // Влево 
        for(j = lastElementCol - 1; j >= zeroValue; j--) array[lastElementRow, j] = resultNumber++; 
        // Вверх
        for(int i = lastElementRow - 1; i >= zeroValue + 1; i--) array[i, zeroValue] = resultNumber++;
        
    }

    return array;
}

Console.Write("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int[,] array = SpiralArray(n, n1);
Print2DArray(array);