// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Через массив 25 % 2 = (1) 14/ 2(0) 

 int[] Conv(int N)
 {
    // Узнаем размер массива (почитать про логарифм)
    int temp = N;
    int i = 0;
    int res = 0;
    for(i = 0, res = 0; N > 0; i++)
    {
        res = N % 2;
        N /= 2;
    }
    //записываем элементы в массив
    int[] array = new int[i];
    for(i = 0, res = 0; temp > 0; i++)
    {
        res = temp % 2;
        array[i] = res;
        temp /= 2;
    }
    
    return array;
 }

int[] ReverseArray(int[] array)
{
    for(int i = 0, j = 1; i < array.Length - j; i++, j++)
    {
        int temp = array[i];
        array[i] = array[array.Length - j];
        array[array.Length - j] = temp;
    }

    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]}");
    Console.WriteLine();
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = Conv(n);
// PrintArray(array);
ReverseArray(array);
Console.Write($"Двоичное представление числа {n}: ");
PrintArray(array);  