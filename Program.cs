// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4.
//8 -> 2, 4, 6, 8.


Console.WriteLine("Fill in a number 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Fill in a number 2: ");
int m = Convert.ToInt32(Console.ReadLine());
    for (int i = n; i <= m; i++)
        if (i % 2 == 0)
        Console.Write(i + " ");
        



         

   
