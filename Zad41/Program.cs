﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите пять чисел чезер пробел: ");
int[] array = new int[5];
string[] input = Console.ReadLine().Split(' ');
int count =0;
for (int i = 0; i < array.Length; ++i)
{
    array[i] = int.Parse(input[i]);
    if (array[i] > 0)
    {
    count = count +1;
    }

}
Console.Write("Количество чисел больше 0: ");
Console.WriteLine(count);
