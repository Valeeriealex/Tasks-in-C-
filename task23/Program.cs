// Задача 23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//5 ->
//1 | 1
//2 | 8
//3 | 27
//4 | 64
//5 | 125

//Console.WriteLine("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 1;

//while (count <= num)
//{
  //Console.WriteLine(Cube(count));
  //count++;
//}

//string Cube(int number)
//{
 // return ($"{number} - > {number*number*number}");
//}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Cube (number);
void Cube (int num)
{
  int count = 1;

  while (count <= num)
  {
    int cube = count*count*count;
    Console.WriteLine ($"{count} {cube}");
    count++;
  }
}