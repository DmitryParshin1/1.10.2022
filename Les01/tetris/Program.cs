// тетрис

void Figure(int x, int y)
{
    Console.Clear();
    for (int i = x - 1; i <= x + 1; i++)
    {
        for (int j = y -1; j <= y + 1; j++)
        {
            Console.SetCursorPosition(i, j);
            Console.Write("+");
        }
    }
}

int x = 10;
int y = 2;

// логика отрисовки всего

new Thread() =>
{
    while(true)
}