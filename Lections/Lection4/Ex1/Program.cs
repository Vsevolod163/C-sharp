﻿// Двумерные массивы

string[,] table = new string[2,5];
// String.Empty;
// table[0, 0]    table[0, 1]   table[0, 2]  table[0, 4]
// table[1, 0]    table[1, 1]   table[1, 2]  table[1, 4]


table[1, 2] = "слово";

for(int rows = 0; rows < 2; rows++)
{
    for(int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
Console.WriteLine();
}

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}    

void RandomArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1; 10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
RandomArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Console.Write(matrix[1,2]);