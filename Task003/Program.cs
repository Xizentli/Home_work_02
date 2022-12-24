/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

Console.Write("Введите число дня недели (от 1 до 7): ");
string numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);
if (number < 8 && number > 0)
{
    if (number > 5) {
        Console.WriteLine("Этот день недели - выходной");
    }
    else {
        Console.WriteLine("Этот день недели - не выходной");
    }
}
else {
    Console.WriteLine("Введено некорректное число.");
}