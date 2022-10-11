// Дано число. Проверить кратно ли оно 7 и 23

int GetVaiue(string text)
{
    int numer = 0;
    Console.WriteLine("Введите число: ");
    int value = int.Parse(Console.ReadLine());
    return value;
}
void Vaiue(int number)
{
    if (number % 7 == 0)
    {
        Console.WriteLine("Число делется на 7");
    }
    if (number % 23 == 0)
    {
        Console.WriteLine("Число делется на 23");
    }
    else
    {
        Console.WriteLine("Число не делется на 7 и 23");
    }
}

Console.Clear();
int index = GetVaiue("Введите число: ");
Vaiue(index);
