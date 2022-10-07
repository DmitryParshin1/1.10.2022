// a + b = c

int Method(string text)
{
    Console.WriteLine("введите числа" + text);
    int value = int.Parse(Console.ReadLine());
    return value
}
int Method2(int c)
{
    a = int.Parse(Console.ReadLine());
    //Console.WriteLine("введите число" + a);
    b = int.Parse(Console.ReadLine());
    //Console.WriteLine("введите число" + b);
    int c = a + b;
}

int N = Method("введите числа");
Method2(N);
