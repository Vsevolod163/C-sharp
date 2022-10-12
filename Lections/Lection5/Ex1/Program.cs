// Показать числа от -N до N

void ShowNumbers(int N)
{
    int temp = N * -1;
    while(temp <= N)
    {
        Console.Write($"{temp} ");
        temp++;
    }
    Console.WriteLine();
}

ShowNumbers(10);

int[] ShowN(int N)
{
    int temp = N * -1;
    int[] array = new int[N * 2 + 1];
    for(int i = 0; i < array.Length; i++, temp++)
    {
        array[i] = temp;
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] array = ShowN(10);

PrintArray(array);

string ShowNum(int N)
{
    string result = String.Empty;
    int temp = N * -1;
    while(temp <= N) 
    {
        result += temp + " ";
        temp++;
    }
    return result; 
}

Console.WriteLine(ShowNum(10));