// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

void Chet(int n)
{
    if(n % 2 == 0) Console.WriteLine($"{n} - Четное");
    else Console.WriteLine($"{n} - Нечетное");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Chet(num);