 // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

 int Max(int n1, int n2)
 {
    int max;
    if(n1 > n2) max = n1;
    else max = n2;
    return max;
 }
 
 Console.Write("Введите первое число: ");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите второе число: ");
 int num2 = Convert.ToInt32(Console.ReadLine());

 int maximum = Max(num1, num2);
 Console.WriteLine($"Максимальное число: {maximum}");