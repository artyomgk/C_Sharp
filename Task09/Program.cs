﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] - {number}");

//Создание нового метода
int MaxDigit(int num)
{
    int firstDigit = num / 10; 
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

// int firstDigit = number / 10; 
// int secondDigit = number % 10;

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшее цифра цисла - {firstDigit}");
// else Console.WriteLine($"Наибольшее цифра цисла - {secondDigit}");

//Использование тернарного оператора
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшее цифра цисла - {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit1 = MaxDigit(57);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");