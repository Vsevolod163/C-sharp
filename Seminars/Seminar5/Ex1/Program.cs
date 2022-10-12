// Задайте массив из 12 элементов, заполненный случайными числами из 
//промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
//элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод Генерация рандомного массива
{
    int[] newArray = new int[size]; //Выделение памяти под массив (запомнить!!!!!)

    for(int i = 0; i < size; i++) newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

int[] CreateArray(int size) // массив с запросом у пользователя
{
    int[] newArray = new int[size];

    for(int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Input {i + 1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array) // Вывод массива
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumofPositive(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++) 
        if(array[i] > 0) sum += array[i];
    
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.WriteLine($"Sum of positive elements is {SumofPositive(array)}");