﻿// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

if (N >= 2)
{
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
}
else
{
    Console.WriteLine("Что-то пошло не так...");
}