// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

int AInB(int A, int B)
{
    if(B != 0) return A * AInB(A, B - 1);

    return 1;
}

int t = AInB(2, 3);
Console.WriteLine(t);