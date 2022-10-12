// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

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

int MinSumRow(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        newArray[i] = sum;
    }

    int indexMinSum = 0;
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        if(newArray[i] < newArray[indexMinSum]) indexMinSum = i;
    }

    return indexMinSum + 1;
}

Console.Write("Введите необходимое количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите необходимое количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

while(rows == columns)
{
    Console.WriteLine("Введите прямоугольный двумерный массив: ");

    Console.Write("Введите необходимое количество строк в массиве: ");
    rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите необходимое количество столбцов в массиве: ");
    columns = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DArray(rows, columns, min, max);

Print2DArray(array);
int result = MinSumRow(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result} строка"); 