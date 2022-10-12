// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Create2DArray(int rows, int columns, int minEl, int maxEl)
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
// 1) Объявлять переменные в момент использования
// 2) Сокращать шаги, где возможно(строка 43, 46)
// 3) При замене элементов сначала выполнить условие (нахождение макс), потом менять после выхода из цикла
// 4) Использовать ИНДЕКСЫ, а не ЗНАЧЕНИЯ элементов

int[,] SortingFromMaxToMin(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPositionCol = j;
            for(int k = j + 1; k < array.GetLength(1); k++)
            {      
                if(array[i, k] > array[i, maxPositionCol]) maxPositionCol = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxPositionCol];
            array[i, maxPositionCol] = temp;
        }
    }

    return array;
}

int[,] array = Create2DArray(7, 5, 1, 99);
Print2DArray(array);
int[,] newArray = SortingFromMaxToMin(array);
Print2DArray(newArray);