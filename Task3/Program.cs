﻿//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] numbers = new int[8];

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 45);
    Console.Write("" + Method (i) + ", ");
 }

int Method (int a)
{
    return numbers[a];
}