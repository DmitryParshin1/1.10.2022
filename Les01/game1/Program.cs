// игра перетащить 3 блина (и далее) из одного стержня к 3-й

void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
    if(count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if(count > 1) Towers(some, on, with, count - 1);
}

Towers();
