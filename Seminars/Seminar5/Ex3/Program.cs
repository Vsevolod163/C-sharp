// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
//число в массиве. 3, массив [6, 7, 19, 345, 3] -> да

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

bool FindNumber(int[] array, int num)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}


Console.Write("ВВедите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] NewArray = CreateRandomArray(7, -11, 9);
ShowArray(NewArray);


bool n = FindNumber(NewArray, number);
Console.WriteLine(n);