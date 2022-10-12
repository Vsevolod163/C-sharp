// Task 1 Напишите программу, которая на вход принимает два числа и 
//проверяет, является ли первое число квадратом второго.

int num1, num2;
string result;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
    result = "Yes";
else
    result = "No";

Console.WriteLine(result);