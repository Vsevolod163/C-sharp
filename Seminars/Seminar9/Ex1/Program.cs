// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.

void ShowNums(int n)
{
    if(n != 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

ShowNums(5);