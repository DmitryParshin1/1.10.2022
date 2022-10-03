int [] array = { 22, 54, 56, 76, 35, 89, 76, 43, 50 };

int n = array.Length;
int find = 76;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}