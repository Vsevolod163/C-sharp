// Среднее арифметическое из 4 чисел

double average(double n1, double n2, double n3, double n4)
{
double res = (n1 + n2 + n3 + n4) / 4;
return res;
}
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите четвертое число: ");
double num4 = Convert.ToDouble(Console.ReadLine());
double result = average(num1, num2, num3, num4);
Console.Write($"Среднее арифметическое данных чисел = {result}");