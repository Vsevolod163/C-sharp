// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

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

int[,] NewArray(int[,] array)
{
    int min = array[0, 0];
    int indexI = 0;
    int indexJ = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < min) 
            {
                indexI = i;
                indexJ = j;
                min = array[i, j];
            }
        }
    }

//     // 1 2 3 4
//     // 5 7 8 9
//     // 0 9 8 2

    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    int newX = 0; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        if (i != indexI)  
        { 
            int newY = 0; 
            for (int j = 0; j < array.GetLength(1); j++) 
            { 
                if (j != indexJ) 
                { 
                    result[newX, newY] = array[i, j]; 
                    newY++; 
                } 
            } 
            newX++; 
        } 
    }


    return result;
}
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if( i == indexI) 
//             {
//                 result[i, j] = array[i, j + 1];
//             }

//             if( j == indexJ)
//             {
//                 result[i, j] = array[i + 1, j];
//             }
//         }
//     }
// }


int[,] array = CreateRandom2DArray(3, 5, 0, 10);
Print2DArray(array);
int[,] newArray = NewArray(array);
Print2DArray(newArray);
