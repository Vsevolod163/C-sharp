// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент. (Через string)

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

string DeleteRow(int[,] array)
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
    string b = String.Empty;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(i == indexRowMin) b = b;
        else
        {
            for(int j = 0; j < array.GetLength(1); j++) 
            {
                if(j == indexColMin) 
                {
                    b += "";
                }
                else b += array[i, j] + " ";
            }
            b = b + (char)13 + (char)10; 
        }
        // b = b + (char)13 + (char)10; // (char)13 - возврат к началу строки, (char)10 - переходи на новую строчку(enter)
    }
    return b;
}

int[,] array = CreateRandomArray(3, 3, -99, 99);
Print2DArray(array);
string newArray = DeleteRow(array);
Console.WriteLine(newArray);
