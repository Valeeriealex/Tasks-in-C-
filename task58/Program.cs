//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
Console.WriteLine("Введите размеры матриц и диапазон случайных значений: ");
int a = InputNumbers("Введите число строк 1-й матрицы: ");
int b = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int c = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

//Создание первой матрицы
int[,] firstMartrix = new int[a, b];
FillArrayRandom(firstMartrix);
Console.WriteLine($"Первая матрица: ");
PrintArray(firstMartrix);

//Создание второй матрицы
int[,] secomdMartrix = new int[b, c];
FillArrayRandom(secomdMartrix);
Console.WriteLine($"Вторая матрица: ");
PrintArray(secomdMartrix);

//Произведение двух матриц
int[,] resultMatrix = new int[a, c];

//Задать матрицу
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

//Напечатать матрицу
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

//
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц: ");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}