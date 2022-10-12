// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам.

string[] RemoveElementsBiggerThan3Symbols(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];

    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

string[] array = {"hello", "1", "mn.", "world", "ppp"};

string[] newArray = RemoveElementsBiggerThan3Symbols(array);
PrintArray(newArray);
