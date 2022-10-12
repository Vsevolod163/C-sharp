// Задайте массив из 12 элементов, заполненный случайными числами из 
//промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
//элементов массива.

int[] RandomArray(int size, int MinElement, int MaxElement)
{
    int[] Array = new int[size];
    for(int i = 0; i < size; i++) Array[i] = new Random().Next(MinElement, MaxElement + 1);
    return Array;
}

int[] InputArray(int size)
{
    int[] Array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int OtricEl(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}

int PositiveEl(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int s = Convert.ToInt32(Console.ReadLine());
int[] array = InputArray(s);
Console.Write("Массив пользователя: ");
PrintArray(array);

int[] RArray = RandomArray(s, 8, 9);

Console.Write("Рандомный Массив: ");
PrintArray(RArray);

int otric = OtricEl(RArray);
Console.WriteLine($"Сумма отрицательных элементов = {otric}");

int positive = PositiveEl(RArray);
Console.WriteLine($"Сумма положительных элементов = {positive}");