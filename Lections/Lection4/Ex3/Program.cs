// Рекурсия (Факториал, фибоначи)

double Factorial (int n) // double решает проблему с переполнением, когда мало int
{
    // 1! = 1
    // 0! = 1
    if(n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}
for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

// f(1) = 1
// f(2) = 1
// f(n) = f(n -1) + f(n - 2)

// double Fibonacci(int n) // каждое следующее равно сумме двух предыдущих
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n -1) + Fibonacci(n -2);
// }

// for(int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }