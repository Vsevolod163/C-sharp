// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

void ShowMToN(int M, int N)
{

    if(M < N)
    {
        ShowMToN(M, N - 1);
    }

    if(M > N)
    {
        ShowMToN(M, N + 1);
    }

    Console.Write(N + " ");
}

ShowMToN(5, 2);