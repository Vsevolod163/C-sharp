// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int NumOfDigits(int num)
{
    int count = 0;

    while(num != 0)
    {
        num /= 10; // num = num /10;
        count++;
    }

    return count;
}


Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = NumOfDigits(number);

Console.WriteLine($"Number of digits of {number} is {res}");