// 11. Напишите программу, которая принимает на вход
// трёхзначное число и на удаляет вторую
// цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int firstDigit = number / 100;
int lastDigit = number % 10;
int numResult = firstDigit * 10 + lastDigit;
// Console.WriteLine($"{number} -> {numResult}");

//Создание метода
int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    return numResult = firstDigit * 10 + lastDigit;
}

int MidDigit = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {MidDigit}");