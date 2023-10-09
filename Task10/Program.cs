// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

using System.Reflection.Emit;

Console.Write("Введите число:  ");
int userNumber1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Math.Abs((userNumber1/10)%10));