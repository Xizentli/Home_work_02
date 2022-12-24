/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число:");
string numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);

number = number % 100;
number = number / 10;

Console.WriteLine($"Вторая цифра числа: {number}");