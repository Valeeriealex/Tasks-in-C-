// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Задайте первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

//Нахождение суммы натуральных чисел в промежутке от M до N
int CountNaturalSum(int m, int n)
{
    if (m == n)
    return n;
    return n + CountNaturalSum(m, n - 1);
}