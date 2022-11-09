// 72. Написать программу возведения числа А в целую стень B

/*int PowerFor(int a, int b)
{
    int result = 1;
    for (int i = 1; i < b; i++)
    {
        result *= a; 
    }
    return result;
}
Console.WriteLine(PowerFor(2, 6));
*/

int PowerFor(int a, int b)
{
    if(b == 1) return 1;
    else return PowerFor(a, b - 1) * a;
}

Console.WriteLine(PowerFor(2, 6));
