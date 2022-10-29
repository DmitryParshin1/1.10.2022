// Показать натуральные числа от 1 до N, N задано

int N = Input(" Введите положительное число ");
int I = 1;
if(N < 1)
{
    Console.WriteLine(" Ввели не положительное число ");
}
Console.WriteLine(Number(N, I));

int Number(int N, int I)
{
    if(N == I)
    return N;

    else
    Console.Write($" {Number(N, I + 1)}, ");
    return I;
}

int Input(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

