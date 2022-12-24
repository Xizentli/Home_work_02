/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.Write("Введите число: ");
string numberStr = Console.ReadLine() ??"";
Boolean hasNoSimbol = true;
for(int i = 0; i < numberStr.Length; i++)
{
    if(numberStr[i] < '0' || numberStr[i] > '9')
        hasNoSimbol = false;
}

if (numberStr.Length > 2 && hasNoSimbol == true)
{
    Console.WriteLine($"Третья цифра числа: {numberStr[2]}");
}
else Console.WriteLine("В введенной строке присутствуют символы, либо нет третьей цифры.");


