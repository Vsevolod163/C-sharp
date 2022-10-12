// Задача 2 кратность на 7 и 23

bool IsKratno(int n1)
{
    if(n1 % 7 == 0 && n1 % 23 == 0) return true;
    else return false;
}

Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

bool kratno = IsKratno(num1);

Console.WriteLine(kratno);