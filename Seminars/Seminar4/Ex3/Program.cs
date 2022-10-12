// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N, кратных трем.

int Multiply(int N)
{
    int multi = 1;
    for(int i = 3; i <= N; i+= 3) 
    {
        multi *= i;
    }
    return multi;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = Multiply(num);
Console.WriteLine($"Multi = {res}");