/*37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

void Array(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(0, 124);
        Console.WriteLine($" {number[i]} ");
    }
}

int Segment(int[] arr)
{
    int qwerty = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99) qwerty++;
    }
    return qwerty;
}

int[] day = new int [6];
Array(day);
Console.WriteLine($"Количество цифр в отрезке {Segment(day)} ");
