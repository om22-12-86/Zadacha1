﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
  Console.WriteLine($"max = {a}"); 
  Console.Write($" min = {b}"); 
}
else
{
    Console.WriteLine($"max = {b}");
    Console.Write($"min = {a}");
}