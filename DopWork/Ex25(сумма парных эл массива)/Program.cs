// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
//последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

void Array(int[] array)
{
    int s = array.Length - 1;
    int i = 0; 
    for(int j = 0; i < s - j; i++, j++)
    {
        array[i] = array[i] * array[s - j];
        Console.Write($"{array[i]} ");
    }
    if(array.Length % 2 != 0) Console.Write(array[i]);
}

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

int[] NewArray = CreateRandomArray(5, -10, 20);
ShowArray(NewArray);

Array(NewArray);