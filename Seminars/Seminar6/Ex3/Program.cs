// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Через строчку или массив 25 % 2 = (1) 14/ 2(0) 

string Conv(int N)
{
    string result = String.Empty;
    while(N > 0)
    {
        result = N % 2 + result;
        N /= 2; 
    }

    return result;
}

Console.Write("Введите N: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат =  {Conv(num)}");
