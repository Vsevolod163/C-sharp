// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] Multi2Arrays(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
    int multi = 0;

    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++) 
        {
            multi = array1[i, j] * array2[i, j];
            newArray[i, j] = multi;
        }
    }

    return newArray;
}

int[,] array1 = Create2DArray(3, 3, -10, 10);
int[,] array2 = Create2DArray(3, 3, -10, 10);
if(array1.GetLength(0) != array2.GetLength(0) || array1.GetLength(1) != array2.GetLength(1))
{
    Console.WriteLine("Ошибка, введите равное количество строк и столбцов в двух массивах");
}
else
{
    Console.WriteLine("Массив 1:");
    Print2DArray(array1);

    Console.WriteLine("Массив 2:");
    Print2DArray(array2);

    int[,] newArray = Multi2Arrays(array1, array2);
    Console.WriteLine("Новый массив:");
    Print2DArray(newArray);
}