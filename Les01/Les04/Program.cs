//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int Method(string text)
{
    Console.Write(text + " : ");
    int value = int.Parse(Console.ReadLine());
    return value;
}
void Method2(int a)
{
    int count = 2;
    while (count < a)
    {
        Console.WriteLine($"{count}");
        count += 2;
    }
}
int N = Method("введите число");
Method2(N);