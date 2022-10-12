// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

void Third(int n)
{
    int res = 0;
    while(n > 999 || n < (-999)) n = n / 10;
        if(n <= 99 && n >= (-99)) Console.WriteLine("Третьей цифры нет");
        else 
        {
            if(n < 0) n = n * (-1);
            res = n % 10;
            Console.WriteLine($"Третья цифра числа: {res}");
        }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Third(num);

