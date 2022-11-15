//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);

//Задать двумерный массив
void FillArrayRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
//Печать массива
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine(); // Строка нужна для того, чтобы был отступ и получилась таблица
    }
}
//Упорядочить массив по убыванию
void SortToLower(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
                if (matrix[i, z] < matrix[i, z + 1])
                {
                    int temp = matrix[i, z + 1];
                    matrix[i, z + 1] = matrix[i, z];
                    matrix[i, z] = temp;
                }
            }
        }
    }
}
//int[] myArr = FillArray(4);
//PrintArray (myArr);