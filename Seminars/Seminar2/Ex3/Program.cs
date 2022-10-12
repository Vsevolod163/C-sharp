// Программа, которая берет трехзначное число и удаляет вторую цифру

int Number (int num)
{
    int first = num / 100;
    int end = num % 10;
    int final = first * 10 + end;
    return final;
}

int number = new Random().Next(100, 1000);
int result = Number(number);
Console.WriteLine($"Заданное число {number}, Результат {result}");