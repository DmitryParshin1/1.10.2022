// Показать натуральные числа от N до 1, N задано

string NumbersRes(int a, int b)
{
    if(a <= b) return NumbersRes(a + 1, b) + $" {a} ";
    else return String.Empty;
    
}
Console.WriteLine(NumbersRes(1, 10));