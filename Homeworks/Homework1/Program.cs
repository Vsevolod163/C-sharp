/* Task 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int Big (int n1, int n2)
{
    int biggest;
    int smallest;
    if (n1 < n2)
    {
        biggest = n2;
        smallest = n1;
    }  
    else
    {
        biggest = n1;
        smallest = n2;
    }
    return biggest;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Big (num1, num2);

Console.Write($"Наибольшее число: {result}");

// Task 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int biggest(int n1, int n2, int n3)
{
    int result = n1;
    if(n1 > n2 && n1 > n3) result = n1;
    if(n2 > n1 && n2 > n3) result = n2;
    if(n3 > n1 && n3 > n2) result = n3;
    return result;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int res = biggest(num1, num2, num3);
Console.Write($"Наибольшее число: {res}");

// Task 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

string chet(int n1)
{
    string result = "Да";
    if((n1 % 2) == 0) result = "Да";
    if((n1 % 2) != 0) result = "Нет";
    return result;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

string res = chet(num);
Console.Write($"Результат: {res}");

// Task 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
void allchet(int n)
{
    int current = 1;
    int result = 1;
    while (current < n)
    {
        if ((current % 2) == 0)
        {
            result = current;;
            Console.Write($"{result} ");
        }
        current++;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

allchet(num);
*/


