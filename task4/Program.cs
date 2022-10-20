//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

Console.WriteLine("Введите три числа и узнайте максимальное из них");
 int A, B, C;
Console.WriteLine("Введите первое число");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
C = Convert.ToInt32(Console.ReadLine());
int max = A;
if (B > A)
max = B;
if (C > max)
max = C;
Console.WriteLine($"Максимальное число найдено {max}");