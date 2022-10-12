// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double degree(double num1, double num2 )
{
    double res = 0;
    while(num2 == 0) 
    {
        Console.Write($"Number B = 0. Try again: ");
        num2 = Convert.ToDouble(Console.ReadLine());
    }
        if(num2 < 0) num2 *= -1;

        int c = (int)num2;
        res = Math.Pow(num1, c);

    return res;
}

Console.Write("Input number A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number B: ");
double B = Convert.ToDouble(Console.ReadLine());


double result = degree(A, B);
Console.WriteLine($"Result = {result}");