// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int getValue(string text)
{
    Console.WriteLine(text + " ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[] Array(int number)
{
    int[] sum = new int[number];
    for (int i = 0; i < number; i++)
    {
        sum[i] = getValue($" Введите число {i + 1}");
    }
    return sum;
}

int Num(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
        count++;
        }
    }
    return count;
}

Console.Clear();

int day = getValue("Введите количество чисел");
int[] arr = Array(day);

Console.WriteLine("Счет положительных чисел..."
                + $"\n{String.Join(", ", arr)} -> {Num(arr)}");