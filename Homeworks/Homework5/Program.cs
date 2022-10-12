/* Task 1. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray(int size, int MinEl, int MaxEl)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) array[i] = new Random().Next(MinEl, MaxEl + 1);

    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int Chet(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }

    return count;
}

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(size, 100, 999);
Console.Write("Массив: ");
PrintArray(array);

int count = Chet(array);
Console.Write($"Количество четных элементов в массиве = {count}");

// Task 2. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray(int size, int MinEl, int MaxEl)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) array[i] = new Random().Next(MinEl, MaxEl + 1);
    
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int Sum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) count += array[i];
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент: ");
int MinEl = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент: ");
int MaxEl = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(size, MinEl, MaxEl);
Console.Write("Массив: ");
PrintArray(array);

int count = Sum(array);
Console.Write($"Сумма элементов, стоящих на нечетных позициях = {count}");

// Task 3. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] InputArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++) 
    {
        Console.Write($"Введите {i + 1} элемент: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

double MinEl(double[] array)
{
    int i = 0; 
    double min = array[i];
    for(i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }

    return min;
}

double MaxEl(double[] array)
{
    int i = 0;
    double max = array[i];
    for(i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }

    return max;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = InputArray(size);
Console.Write("Массив: ");
PrintArray(array);

double MinElement = MinEl(array);
Console.WriteLine($"Минимальный элемент = {MinElement}");

double MaxElement = MaxEl(array);
Console.WriteLine($"Максимальный элемент = {MaxElement}");

double r = MaxElement - MinElement;

Console.WriteLine($"Разница между максимальным и минимальным элементом = {r}");
*/