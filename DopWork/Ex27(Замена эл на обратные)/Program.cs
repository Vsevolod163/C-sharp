// Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] Reverse(int[] array)
{
    for(int i = 0; i < array.Length; i++) array[i] *= -1;

    return array;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент: ");
int MinEl = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент: ");
int MaxEl = Convert.ToInt32(Console.ReadLine());

int[] array = RandArray(size, MinEl, MaxEl);
Console.Write("Массив: ");
PrintArray(array);

int[] reverse = Reverse(array);
Console.Write("Новый массив: ");
PrintArray(reverse);