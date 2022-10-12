// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int sum(int A)
{
    int count = 0;
    for(int i = 1; i <= A; i++) count = count + i;
    return count;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = sum(num);
Console.WriteLine($"Sum = {res}");