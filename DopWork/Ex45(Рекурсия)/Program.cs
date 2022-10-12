// Умножать последующее число на 2

double Factorial (int n) // double решает проблему с переполнением, когда мало int
{
    // 1! = 1
    // 0! = 1
    if(n > 500) return 1;
    else return 2 * Factorial(n * 2);
}
for(int i = 1; i < 9; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

