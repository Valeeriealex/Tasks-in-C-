//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//Метод создания массива
int [,] CreateMatrixRndInt (int rows, int columns)
{
    var matrix = new int [rows, columns];
    var rnd = new Random ();
    for (int i = 0; i < matrix.GetLength (0); i++)
{
    for (int j = 0; j < matrix.GetLength (1); j++)
    {
        matrix[i, j] = rnd.Next(-100, 100) / 10;
    }
}
return matrix;
}

//Метод печати
void PrintMatrix(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j=0; j < matrix.GetLength (1); j++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write ($"{matrix[i, j], 4}, ");
                else Console.WriteLine($"{matrix[i, j], 4} ");
            }
            Console.WriteLine("|");
        }
}
int [,] array2D = CreateMatrixRndInt (3, 4);
PrintMatrix(array2D);