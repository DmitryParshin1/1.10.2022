// Показать натуральные числа от M до N, N и M заданы

void Print(int s, int e)
{
    Console.Write(s + ", ");
    if(s < e) Print(s + 1, e);
    
}

void Print2(int s, int e)
{
    Console.Write(e + ", ");
    if(s < e) Print2(s, e - 1);
    
}

Print(1, 10); Console.WriteLine();
Print2(1, 10); Console.WriteLine();