// Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов 
//массива, значения которых лежат в отрезке [10,99].

int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод Генерация рандомного массива
{
    int[] newArray = new int[size]; //Выделение памяти под массив (запомнить!!!!!)

    for(int i = 0; i < size; i++) newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array) // Вывод массива
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

    Console.WriteLine();
}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

int[] NewArray = CreateRandomArray(12, -100, 175);
ShowArray(NewArray);

int c = Count(NewArray);
Console.WriteLine($"Количество элементов в отрезке [10, 99] = {c}");