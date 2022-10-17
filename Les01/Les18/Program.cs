// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void Get(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(1,10);
        Console.Write($"{number[i]}");
    }
}

int Qwerty(int[] arr)
{
    int sum = 0;
    for (int index = 0; index < arr.Length; index += 2)
    {
        sum = sum + arr[index];
    }
    return sum;
}

Console.Clear();
int [] red = new int [9];
Get(red);
Console.WriteLine($" Сумма нечетных элементов {Qwerty(red)} ");

