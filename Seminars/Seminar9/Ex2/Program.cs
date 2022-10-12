// Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.

int SumOfDigits(int n)
{
    if(n != 0) return n % 10 + SumOfDigits(n / 10);
    return 0;
}

int sum = SumOfDigits(143);
Console.WriteLine(sum);