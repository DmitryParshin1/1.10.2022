// Показать натуральные числа от M до N, N и M заданы

string NumbersRec(int a, int b)
{
    if(a <= b) return $" {a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 10));


string NumbersRes(int a, int b)
{
    if(a <= b) return NumbersRes(a + 1, b) + $" {a} ";
    else return String.Empty;
    
}
Console.WriteLine(NumbersRes(1, 10));

