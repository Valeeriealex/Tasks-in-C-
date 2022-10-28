// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Метод создания массива
int [,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    var matrix = new int [rows, columns];
    var rnd = new Random ();
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"{ sum / matrix.GetLength(0)} ");
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

int [,] array2D = CreateMatrixRndInt (3, 4, 1, 100);
PrintMatrix(array2D);

//Поиск суммы
 //   double sum = 0;
   // for (int i = 0; i < matrix.GetLength(0); i++)
   // {
  //      sum += matrix[i, j];
   // }
   // Console.Write($"{ sum / matrix.GetLength(0)} ");
//}
//Console.ReadLine();