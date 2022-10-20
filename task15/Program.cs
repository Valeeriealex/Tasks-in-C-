// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под числом " + a + " - Выходной день");
        }
        else
        {
            Console.Write("Под числом " + a + " - Рабочий день");
        }
    }
    else
    {
    
    }
     return ("Введенное число не входит в отрезок чисел от 1 до 7");
}