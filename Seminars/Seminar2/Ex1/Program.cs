// Наибольшее из двух чисел в двузначном числе

int FindBiggerDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec) return ed;
    else return dec;

}

int number = new Random().Next(10,100);
int digit = FindBiggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {digit}");