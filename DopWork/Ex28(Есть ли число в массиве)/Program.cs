// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
//число в массиве. 3, массив [6, 7, 19, 345, 3] -> да

int[] RandArray(int size, int MinEl, int MaxEl)
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

bool Number(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент: ");
int MinEl = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент: ");
int MaxEl = Convert.ToInt32(Console.ReadLine());

int[] array = RandArray(size, MinEl, MaxEl);
PrintArray(array);

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

bool number = Number(array, n);

Console.WriteLine(number);

if(number == true) Console.WriteLine($"Число {n} присутствует в массиве");
else Console.WriteLine($"Числа {n} нет в массиве");