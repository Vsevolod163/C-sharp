// Напишите программу, которая проверяет является ли пятизначное число палиндромом

void Pal(int n)
{
    while(n > -10000 && n < 10000 || n < - 99999 || n > 99999)
    {
        Console.Write("Ошибка, попробуйте еще раз: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
        if(n % 10 == n / 10000 && n / 10 % 10 == n / 1000 % 10) Console.WriteLine($"Число {n} - палиндром");
        else Console.WriteLine($"Число {n} не является палиндромом");
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Pal(num);