// тетрис

void Figure(int x, int y)
{
    Console.SetCursorPosition(x, y);
    Console.Write("+");
    Console.SetCursorPosition(x, y + 1);
    Console.Write("+");
    Console.SetCursorPosition(x, y + 2);
    Console.Write("+");
    Console.SetCursorPosition(x + 1, y + 2);
    Console.Write("+");
}

int x = 10;
int y = 2;

// логика отрисовки всего

new Thread(() =>
{
    while(true)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 18);

        System.Console.Write("++++++++++++++++++++++++");

        Figure(x, y);
        Thread.Sleep(500);
        y++;
        if(y > 15) y = 1;
    }
}).Start();

//Логика нажатие кнопок

while (true)
{
    var key = Console.ReadKey(true).Key;

    if(key == ConsoleKey.LeftArrow)
    {
        x--;
        Figure(x, y);
    }
    if(key == ConsoleKey.RightArrow)
    {
        x++;
        Figure(x, y);
    }
}

// поворот фигуры