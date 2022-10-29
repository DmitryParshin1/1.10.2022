// Показать натуральные числа от N до 1, N задано

/*int getValue(string text)
{
    Console.WriteLine(text + "  ");
    int value = int.Parse(Console.ReadLine());
    return value;
}*/

void Print(int s, int e)
{
    Console.Write(s + ", ");
    if(s < e) Print(s + 1, e);
    
}
Print(1, 10); Console.WriteLine();