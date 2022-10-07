//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2; b = 10 -> max = 10
//a = -9; b = -3 -> max = -3

Console.WriteLine ("Ведите два числа, чтобы определить, какое из них больше, а какое меньше");
int A, B;
Console.WriteLine ("Введите первое число");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
B = Convert.ToInt32(Console.ReadLine());

            bool Chto0 = A > B;
            bool Chto1 = A == B;
            bool Chto2 = A < B;
 
            if (Chto0)
            {
                Console.WriteLine($"Число {A} больше чем {B}");
            }
            else if (Chto1)
            {
                Console.WriteLine($"Числа {A} и {B} равны");
            }
            else
            {
                Console.WriteLine($"Число {B} больше чем {A}");
            }

