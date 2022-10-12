// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Через строку 25 % 2 = (1) 14/ 2(0) 

string Conv(int N)
{
    string result = String.Empty;

    for(int i = 0; N > 0; i++)
    {   
        result = N % 2 + result; // Предыдущий result будет вставать на строку после нового
        N /= 2; 
    }

    return result;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {n} в двоичном представлении: {Conv(n)}");