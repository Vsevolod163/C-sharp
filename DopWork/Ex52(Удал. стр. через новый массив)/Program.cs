// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

int[,] CreateRandomArray(int rows, int columns, int minEl, int maxEl)
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

int[,] DeleteRow(int[,] array)
{
    int min = array[0, 0];
    int indexRowMin = 0;
    int indexColMin = 0;
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < min) 
            {
                min = array[i, j];
                indexRowMin = i;
                indexColMin = j;
            }
        }
    } 

    int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int newRow = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        if (i != indexRowMin)
        {
            int newCol = 0;
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(j != indexColMin)
                {
                    resultArray[newRow, newCol] = array[i, j];
                    newCol++;
                }
            }
            newRow++;
        }
    }

    return resultArray;
}

// 1 5 0 7
// 1 3 9 4
// 8 5 2 7

int[,] array = CreateRandomArray(3, 5, 0, 9);
Print2DArray(array);
int[,] result = DeleteRow(array);
Print2DArray(result);