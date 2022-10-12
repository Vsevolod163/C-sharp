// Task 4 Напишите программу, которая принимает на вход число (N) и выдаёт последовательность квадратов чисел от 1 до N. (void)

void Numbers(double N)
{
    int current = 1;
    while (current <= N)
    {
        double quad = current * current;
        Console.Write(quad + " ");
        current ++;
    }    


} 
Console.Write("Input number: ");
double num = Convert.ToDouble(Console.ReadLine());
Numbers(num);