//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int len = 4; //длина = 4
int[,] table = new int[len, len]; //двумерная таблица 4 на 4
FillArraySpiral(table, len); //заполнить массив спирально через таблицу и длину
PrintArray(table); //напечатать эту таблицу


//Заполнения массива по спирали
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1; //значение
    for (int e = 0; e < n * n; e++)
    {
        int z = 0;
        do { array[i, j++] = value++; } while (++z < n - 1);
        for (z = 0; z < n - 1; z++) array[i++, j] = value++;
        for (z = 0; z < n - 1; z++) array[i, j--] = value++;
        for (z = 0; z < n - 1; z++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//Печать массива
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}