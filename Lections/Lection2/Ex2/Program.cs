// Task 2 Массивы

int[] array = {1, 2, 3, 4, 8, 5, 6, 7, 8};

int n = array.Length;
int find = 8;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}
