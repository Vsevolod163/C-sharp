/* Task 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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

int[,] array = Create2DArray(5, 4, -99, 99);
Print2DArray(array);
int[,] newArray = SortingFromMaxToMin(array);
Print2DArray(newArray);

// Task 2. Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

// Task 3. Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

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

// Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

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

// Task 5. Заполните спирально массив 4 на 4.

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
*/