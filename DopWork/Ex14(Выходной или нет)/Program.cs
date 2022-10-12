//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Day(int n)
{
    while(n < 1 || n > 7)
    {
        Console.Write("Ошибка, попробуйте еще раз: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
        Console.Write("Этот день выходной? ");
        if(n >= 1 && n <=5) Console.Write("Нет");
        else Console.Write("Да");
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