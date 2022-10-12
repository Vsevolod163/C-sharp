// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int Second(int n)
{
    int s;
    while(n >= -99 && n <= 99 || n <= -1000 || n >= 1000)
    {
        Console.Write("Ошибка, попробуйте еще раз: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
        s = n / 10 % 10;
        if(s < 0) s = s * (-1);
    return s;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Second(num);
Console.WriteLine($"Вторая цифра числа = {result}");