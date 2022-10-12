// Задайте массив вещественных чисел.
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