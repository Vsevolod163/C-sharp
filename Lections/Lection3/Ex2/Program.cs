﻿// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // Инкримент(увеличение на единицу), уменьшение - декримент
    }
}
//Method21(msg: "Текст", count: 4);
Method21(count: 3, msg: "Новый текст");