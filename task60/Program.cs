//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Например, задан массив размером 2 x 2 x 2.
//Результат:
//66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
//34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] array3D = new int[2, 2, 2];
FillArrayRandom(array3D);
PrintIndex(array3D);

//Задать трехмерный массив из двузначных чисел
void FillArrayRandom(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[z, i, j] = new Random().Next(9, 99);
            }
        }
    }
}

//Печать индекса
void PrintIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"{matrix[i, j, z]}({i},{j},{z}) ");
            }
        }
    }
}