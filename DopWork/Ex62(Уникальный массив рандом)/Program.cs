//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
int[,,] Generate3DArray(int rows, int columns, int lines)
{
    int[,,] array3D = new int[rows, columns, lines];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {   
                int checkable = new Random().Next(10, 100);
                while (ElementExistence(array3D, checkable) == true) checkable = new Random().Next(10, 100);
                array3D[i, j, k] = checkable;
            }
        }
    }
    return array3D;
}
void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $" ({i}, {j}, {k})" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
bool ElementExistence(int[,,] array, int element)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element) count++;
            }
        }
    }
    if (count > 0) return true;
    else return false;
}
int[,,] my3DArray = Generate3DArray(2, 2, 2);
Show3DArray(my3DArray);
