﻿// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 % num1 == 0)
{
    Console.WriteLine($"Второе число ({num2}) является кратным первому ({num1}).");
}
else
{
    Console.WriteLine($"Второе число ({num2}) НЕ является кратным первому ({num1}). Остаток от деления - {num2 % num1}.");
}