// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Каждая из сторон должна быть меньше суммы двух других (a < b + c)

bool triangle(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.Write("Введите длину стороны a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool res = triangle(a, b, c);
if(res == true) Console.WriteLine("Такой треугольник существует");
else Console.WriteLine("Такого треугольника нет");