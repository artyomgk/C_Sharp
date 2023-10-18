// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdDigit (int num)
// {
    
// }

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
} 


int res = ThirdDigit(number);
Console.WriteLine(res);