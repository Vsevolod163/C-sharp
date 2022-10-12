// Завершите функцию квадратной суммы, чтобы она возводила в квадрат 
// каждое переданное ей число, а затем суммировала результаты.
// Например, for [1, 2, 2]это должно возвращаться , 9 
// потому что 1^2 + 2^2 + 2^2 = 9.

int Quadrat(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= array[i];
        sum += array[i];
    }

    return sum;
}
int[] array = {1, 2, 2, 7, 3};
Console.WriteLine($" Сумма элементов = {Quadrat(array)}");