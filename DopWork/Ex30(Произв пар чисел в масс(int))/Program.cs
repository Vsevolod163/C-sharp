// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
//последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

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

int[] Multi(int[] array)
{
    int count = array.Length / 2;
    int[] NewArray = new int[count];
    int l = array.Length - 1;
    int i = 0;

    if(array.Length % 2 == 0) NewArray = new int[count];
    else NewArray = new int[count + 1];

    for(int j = 0; i < l - j; i++, j++)
    {
        array[i] *= array[l - j];
        NewArray[i] = array[i];
    }
    
    if(array.Length % 2 != 0) NewArray[i] = array[i];

    return NewArray;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int MinEl = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int MaxEl = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(size, MinEl, MaxEl);
Console.Write("Массив: ");
PrintArray(array);

int[] multi = Multi(array);
Console.Write($"Произведение парных элементов: ");
PrintArray(multi);

