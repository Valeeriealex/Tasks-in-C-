// Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());

//Рекурсия вывода всех натуральных чисел в промежуткеот N до 1:
void NumberCounter (int number)
{
     if (number < 0) 
     //break;
     Console.Write("Вы задали не натуральное число!");
     if (number == 0) return;
     Console.Write(number);
     NumberCounter (number - 1);
}
Console.Write($"Числа в промежутке от {number} до 1: ");
NumberCounter(number);