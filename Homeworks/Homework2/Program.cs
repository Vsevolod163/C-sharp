// Task1 Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа

int SecondNumber(int n)
{
    while(n > 999 || n < -999 || n <= 99 && n >= -99) 
    {
        Console.Write("Ошибка, попробуйте еще раз: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
        if(n < 0) n = n * (-1);
        n = (n / 10) % 10;
    return n;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = SecondNumber(num);
Console.WriteLine($"Вторая цифра числа: {res}");

/* Task2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

void ThirdNumber(int n)
{
    while(n >= 1000 || n <= -1000) n = n / 10;
        if(n <= 99 && n >= -99) Console.WriteLine("Третьей цифры нет");
        else 
        {   
            if(n < 0) n = n * (-1);
            n = n % 10;
            Console.WriteLine($"Третья цифра числа: {n}");
        }    
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNumber(num);

//Task3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

void Day(int n)
{
    while(n < 1 || n > 7)
    {
        Console.Write("Ошибка. Попробуйте еще раз: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
        if(n == 6 || n == 7) Console.Write("Является ли этот день выходным? Да");
        
        else Console.Write("Является ли этот день выходным? Нет");
}
Console.WriteLine("1 = Понедельник");
Console.WriteLine("2 = Вторник");
Console.WriteLine("3 = Среда");
Console.WriteLine("4 = Четверг");
Console.WriteLine("5 = Пятница");
Console.WriteLine("6 = Суббота");
Console.WriteLine("7 = Воскресенье");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Day(num);
*/