// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Каждая из сторон должна быть меньше суммы двух других (a < b + c)

bool Len(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.Write("Введите длину a: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину b: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину c: ");
int C = Convert.ToInt32(Console.ReadLine());

bool f = Len(A, B, C);
Console.WriteLine(f);