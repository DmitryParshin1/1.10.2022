// работа с файлами

string path = "file.txt";
// надо делать скопировать путь из самой папки
string text = File.ReadAllText(path);

int pos = text.IndexOf("\n");

int a = 0, b = 0;
string[] lines = File.ReadAllLines(path);
for (int i = 0; i < lines.Length; i++)
{
    string[] symbols = lines[i].Split('=');
    if(symbols[0].Trim() == "a")
    a = Convert.ToInt32(symbols[1].Trim());

    if(symbols[0].Trim() == "b");
    b = Convert.ToInt32(symbols[1].Trim());
}

Console.WriteLine($"a = {a}  b = {b}");

File.WriteAllText("output.db", $"результат = {a * b}");

