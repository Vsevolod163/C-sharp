 // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 int sum(int num)
 {
    int res = 0;
    while(num != 0)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
 }

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = sum(number);
Console.WriteLine($"Sum of digits in number {number} = {result}");
