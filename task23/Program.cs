﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Console.WriteLine(Math.Pow(i,3) + " ");
    i++;
}