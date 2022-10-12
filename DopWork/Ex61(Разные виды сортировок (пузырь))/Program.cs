// Отсортировать столбцы и строки от меньшего к большему

int[] CreateArray(int row, int minEl, int maxEL)
{
    int[] array = new int[row];
    for(int i = 0; i < row; i++) array[i] = new Random().Next(minEl, maxEL + 1);

    return array;
}

int[,] Create2DArray(int rows, int columns, int minEl, int maxEl)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) array[i, j] = new Random().Next(minEl, maxEl + 1);
    }

    return array;
}

int[,] SortArrayRows(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, k] < array[i, minPosition]) minPosition = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = temp;
        }
    }

    return array;
}

int[,] SortArrayColumns(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
        {
            int minPosition = i;
            for(int l = i + 1; l < array.GetLength(0); l++)
            {
                if(array[l, j] < array[minPosition, j]) minPosition = l;
            }
            int temp = array[i, j];
            array[i, j] = array[minPosition, j];
            array[minPosition, j] = temp; 
        }
    }

    return array;
}

int[,] BubbleSort2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                for(int k = 0; k < array.GetLength(0); k++)
                {
                    for(int l = 0; l < array.GetLength(1); l++)
                    {
                        if(array[i, j] < array[k, l])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[k, l];
                            array[k, l] = temp;
                        }
                    }
                }
            }
        }
                
    return array;
}

int[] BubbleSortArray(int[] array)
{
    int temp = 0;
    for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array.Length; j++)
            {
                if(array[i] < array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.GetLength(0); i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
    Console.WriteLine();
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
   
int[] array1 = CreateArray(7, -10, 10);
PrintArray(array1);

int[]newArray1 = BubbleSortArray(array1);
PrintArray(newArray1);

int[,] array2 = Create2DArray(10, 10, -100, 100);
Print2DArray(array2);
// int[,] newArray = SortArrayRows(array);
// int[,] newArray2 = SortArrayColumns(array);
// Print2DArray(newArray2);

int[,] newArray2 = BubbleSort2DArray(array2);
Print2DArray(newArray2);