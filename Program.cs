﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Если решаете математически через рандом, то проверка не нужна на трехзначность. Если через строки, то она обязательна)
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Num = new Random().Next(100, 1000);
string NumStr = Num.ToString();
Console.WriteLine ($"Вторая цифра числа {Num} - {NumStr[1]}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Если решаете математически максимум берем 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Number = new Random().Next(100000);
string NumberStr = Number.ToString();
if(NumberStr.Length < 3) {
Console.WriteLine($"В числе {Number} нет третьей цифры");
}
else Console.WriteLine($"В числе {Number} третья цифра {NumberStr[2]}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. (Проверка выхода за пределы значений недели, т.е. < 1 и > 7)
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели ");
int day = int.Parse(Console.ReadLine()!);
if (day < 1 && day > 7) {
    Console.WriteLine("Нет такого дня недели");
}
else if (day == 6 ) {
    Console.WriteLine("Выходной");
}
else if (day == 7 ) {
    Console.WriteLine("Выходной");
}
else Console.WriteLine("Рабочий день");