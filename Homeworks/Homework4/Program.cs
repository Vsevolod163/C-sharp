/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double degree(double num1, double num2 )
{
    double res = 1;
    while(num2 == 0) 
    {
        Console.Write($"Number B = 0. Try again: ");
        num2 = Convert.ToDouble(Console.ReadLine());
    }
        if(num2 < 0) num2 *= -1;
        for(int i = 1; i <= num2; i++) res *= num1;
        
    return res;
}

Console.Write("Input number A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number B: ");
double B = Convert.ToDouble(Console.ReadLine());


double result = degree(A, B);
Console.WriteLine($"Result = {result}");

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

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] InputArray(int size)
{
    int[] NewArray = new int[size];
    Console.WriteLine("Input elemets of Array");
    for(int i = 0, k = 1; i < NewArray.Length; i++, k++)
    {
        Console.Write($"Input n{k}: ");
        int n = Convert.ToInt32(Console.ReadLine());
        NewArray[i] = n;
    }
    return NewArray;
}

void PrintArray(int[] array)
{
    int i = array.Length - 1;
    Console.Write("[");
    for(i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[i]}]");
}

Console.Write("Input Array Size: ");
int s = Convert.ToInt32(Console.ReadLine());
int[] res = InputArray(s);
Console.Write("Array: ");
PrintArray(res);
*/