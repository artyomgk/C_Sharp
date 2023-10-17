﻿// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);

int MidDigit (int num)
{
    return (num / 10) % 10;
}

int mid = MidDigit(number);
Console.WriteLine($"{number} -> {mid}");