﻿// Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] Generetion()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 8);
    }
    return array;
}

void print(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}
print(Generetion());