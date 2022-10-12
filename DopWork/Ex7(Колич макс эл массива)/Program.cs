// Посчитать, сколько максимальных элементов в массиве (в строке 21, когда находится новое наибольшее число, счетчик сбрасывается)

void PrintArray(int[] arr)
{   
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int CountEl(int[] arr)
{
    int max = 0;
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > arr[max]) 
        {
            max = i;
            count = 1;
        }
        else
            if(arr[i] == arr[max]) count = count + 1;
    }    
    Console.WriteLine($"Максимальное число = {arr[max]}");
    return count;
}

int[] array = {29, 2, 18, 29, 29, 15, 1, 14};

PrintArray(array);

int max = CountEl(array);
Console.WriteLine($"Количество максимальных элементов = {max}");