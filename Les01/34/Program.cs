// Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

void Array(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(-9,10);
        Console.Write($" {number[i]} ");
    }
}

int[] Change(int[] arr)
{
    //int qwerty = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
        Console.Write($" противоположные цифры {arr[i]} ");
    }
    return arr;
    }

    Console.Clear();
    int[] day = new int [6];
    Array(day);
    Change(day);
    
    
