// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.(Не через массив)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int Count(int M)
{
    int count = 0;
    for(int i = 1; i <= M; i++)
    {
        Console.Write($"Введите число {i}: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n > 0) count++;
    }

    return count;
}

Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Count(n);
Console.WriteLine($"Чисел больше 0: {result}");