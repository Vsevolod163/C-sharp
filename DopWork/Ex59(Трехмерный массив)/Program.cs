// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int[,,] Create3DArray(int rows, int columns, int lines)
{
    int[,,] array = new int[rows, columns, lines];
    int t = 0;

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < lines; k++, t++) 
            {
                array[i, j, k] = 10 + t; 
            }
        }
    }
    
    return array;
}

void Print3DArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++) Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] array = Create3DArray(2, 2, 2);
if(array[array.GetLength(0) - 1, array.GetLength(1) - 1, array.GetLength(2) - 1] < 100)
{
    Print3DArray(array);
}
else Console.WriteLine("Уменьшите размер массива");