double calc(double num1, char b, double num2)
{
    double res = 0;
    
    if(b == '+') res = num1 + num2;
    else
    {
        if(b == '-') res = num1 - num2;
        else
        {
            if(b == '*') res = num1 * num2;
            else
            {
                if(b == '/') res = num1 / num2;
            }
        }
    }
    return res;
    
}

Console.Write("Input first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input char: ");
char z = Convert.ToChar(Console.ReadLine());
Console.Write("Input second number: ");
double number2 = Convert.ToDouble(Console.ReadLine());

double result = calc(number1, z, number2);
Console.WriteLine($"{number1} {z} {number2} = {result}");