// Работа с базой данных

string[] FirstName = File.ReadAllLines("FirstName.txt");
string[] LastName = File.ReadAllLines("LastName.txt");

string[] output = new string[1000];

File.WriteAllText("result111.csv", "ID;Имя;Фамилия;Возраст;\n");

for (int i = 0; i < 1000; i++)
{
    string manFName = FirstName[Random.Shared.Next(FirstName.Length)];
    string manLName = LastName[Random.Shared.Next(LastName.Length)];
    int age = Random.Shared.Next(18, 70);
    output[i] = $"{i + 1}; {manFName}; {manLName}; {age}";

}

File.AppendAllLines("result111.csv", output);