﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Write($"N=");
int N = int.Parse(Console.ReadLine());
int i = 1;

while (N>=i)
{
    Console.Write($"{Math.Pow(i,3)}, ");
    i++;
}

