// Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) array[i] *= -1;
    return array;
}

int[] NewArray = CreateRandomArray(7, -11, 9);
ShowArray(NewArray);
int[] RevArray = ReverseArray(NewArray);
ShowArray(RevArray);