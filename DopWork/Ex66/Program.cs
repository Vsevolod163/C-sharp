
string ThirdNum(int num)
{
    string res = String.Empty;
    if(num > 99 && num < 1000) res = Convert.ToString(num % 10);
    else res = "Число не трехзначное";

    return res;
}

string result = ThirdNum(1787);
Console.WriteLine($"Третья цифра числа = {result}");