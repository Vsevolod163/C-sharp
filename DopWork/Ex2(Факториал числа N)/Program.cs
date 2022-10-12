// Факториал числа N

int fact(int n)
{
    int res = 1;
    for(int i = 1; i <= n; i++) 
    {
        res = res * i;
    }
        if(n == 0) res = 1;
    return res;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = fact(num);
Console.Write($"Факториал {num} = {result}");