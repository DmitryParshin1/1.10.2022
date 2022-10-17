// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void Get(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(0,100);
        Console.Write($" {number[i]} ");
    }
}

int Arr(int[] qwerty)
{
int max = qwerty[0];
int min = qwerty[0];
for (int index = 0; index < qwerty.Length; index++)
{
    if(qwerty[index] > max)
    {
        max = qwerty[index];
    }
    if(qwerty[index] < min)
    {
        min = qwerty[index];
    }
}
return max - min;
}

Console.Clear();
int[] day = new int [9];
Get(day);
Console.WriteLine($" Разница между Мах и Мин {Arr(day)} ");